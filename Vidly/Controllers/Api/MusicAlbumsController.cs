using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/MusicAlbums")]
    [ApiController]
    public class MusicAlbumsController : ControllerBase
    {
        private readonly VidlyDbContext _dbContext;

        public MusicAlbumsController(VidlyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("")]
        public IEnumerable<MusicAlbum> GetMusicAlbums()
        {
            return _dbContext.MusicAlbums.ToList();
        }

        [Route("{id}")]
        public ActionResult<MusicAlbum> GetMusicAlbum(int id)
        {
            var musicAlbum = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == id);

            if (musicAlbum == null)
                return NotFound();

            return musicAlbum;
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult<MusicAlbum> CreateMusicAlbum(MusicAlbum musicAlbum)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _dbContext.MusicAlbums.Add(musicAlbum);
            _dbContext.SaveChanges();

            return musicAlbum;
        }

        [HttpPut]
        public ActionResult UpdateMusicAlbum(MusicAlbum musicAlbum)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var musicAlbumInDb = _dbContext.MusicAlbums.SingleOrDefault(ma => ma.Id == musicAlbum.Id);

            if (musicAlbumInDb == null)
                return NotFound();

            musicAlbum.Artist = musicAlbum.Artist;
            musicAlbumInDb.Title = musicAlbum.Title;
            musicAlbum.NumberInStock = musicAlbum.NumberInStock;
            musicAlbum.GenreId = musicAlbum.GenreId;
            musicAlbum.ReleaseDate = musicAlbum.ReleaseDate;

            _dbContext.SaveChanges();

            return Ok();
        }

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
