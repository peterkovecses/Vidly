using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
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

        // GET /api/musicalbums
        [HttpGet]
        public IEnumerable<MusicAlbumDTO> GetMusicAlbums(string query = null)
        {
            var musicAlbumsQuery = _dbContext.MusicAlbums.Include(ma => ma.Genre);

            if (!String.IsNullOrWhiteSpace(query))
                musicAlbumsQuery = (IIncludableQueryable<MusicAlbum, MusicGenre>)musicAlbumsQuery.Where(m => m.Title.Contains(query));

            return musicAlbumsQuery.ToList().Select(_mapper.Map<MusicAlbum, MusicAlbumDTO>);
        }

        // GET /api/musicalbums/1
        [HttpGet("{id}")]
        public IActionResult GetMusicAlbum(int id)
        {
            var musicAlbum = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == id);

            if (musicAlbum == null)
                return NotFound();

            return Ok(_mapper.Map<MusicAlbum, MusicAlbumDTO>(musicAlbum));
        }

        // POST /api/musicalbums
        [HttpPost]
        public IActionResult CreateMusicAlbum(MusicAlbumDTO musicAlbumDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var musicAlbum = _mapper.Map<MusicAlbumDTO, MusicAlbum>(musicAlbumDTO);

            _dbContext.MusicAlbums.Add(musicAlbum);
            _dbContext.SaveChanges();

            musicAlbumDTO.Id = musicAlbum.Id;

            return Created(new Uri(Request.GetDisplayUrl() + "/" + musicAlbum.Id), musicAlbumDTO);
        }

        // PUT /api/musicalbums/1
        [HttpPut("{id}")]
        public IActionResult UpdateMusicAlbum(int id, MusicAlbumDTO musicAlbumDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var musicAlbumInDb = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == id);

            if (musicAlbumInDb == null)
                return NotFound();

            musicAlbumDTO.Id = id;

            _mapper.Map(musicAlbumDTO, musicAlbumInDb);

            _dbContext.SaveChanges();

            return Ok();
        }

        // DELETE /api/musicalbums/1
        [HttpDelete("{id}")]
        public IActionResult DeleteMusicAlbum(int id)
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
