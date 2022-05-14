using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MusicAlbumsController : ControllerBase
    {
        private readonly VidlyDbContext _dbContext;
        private readonly IMapper _mapper;

        public MusicAlbumsController(VidlyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [Route("")]
        public IEnumerable<MusicAlbumDTO> GetMusicAlbums()
        {
            return _dbContext.MusicAlbums.ToList().Select(_mapper.Map<MusicAlbum, MusicAlbumDTO>);
        }

        [Route("{id}")]
        public ActionResult<MusicAlbumDTO> GetMusicAlbum(int id)
        {
            var musicAlbum = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == id);

            if (musicAlbum == null)
                return NotFound();

            return _mapper.Map<MusicAlbum, MusicAlbumDTO>(musicAlbum);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult<MusicAlbumDTO> CreateMusicAlbum(MusicAlbumDTO musicAlbumDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var musicAlbum = _mapper.Map<MusicAlbumDTO, MusicAlbum>(musicAlbumDTO);

            _dbContext.MusicAlbums.Add(musicAlbum);
            _dbContext.SaveChanges();

            musicAlbumDTO.Id = musicAlbum.Id;

            return musicAlbumDTO;
        }

        [Route("Edit")]
        [HttpPut]
        public ActionResult UpdateMusicAlbum(MusicAlbumDTO musicAlbumDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var musicAlbumInDb = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == musicAlbumDTO.Id);

            if (musicAlbumInDb == null)
                return NotFound();

            _mapper.Map<MusicAlbumDTO, MusicAlbum>(musicAlbumDTO, musicAlbumInDb);

            _dbContext.SaveChanges();

            return Ok();
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public ActionResult DeleteMusicAlbum(int id)
        {
            var musicAlbumInDb = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == id);

            if (musicAlbumInDb == null)
                return NotFound();

            _dbContext.MusicAlbums.Remove(musicAlbumInDb);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
