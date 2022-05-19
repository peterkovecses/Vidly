using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Dtos;
using Vidly.Interfaces;

namespace Vidly.Controllers.Api
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MusicAlbumsController : ControllerBase
    {
        private readonly IMusicAlbumService _musicAlbumService;

        public MusicAlbumsController(IMusicAlbumService musicAlbumService)
        {
            _musicAlbumService = musicAlbumService;
        }

        // GET /api/musicalbums
        [HttpGet]
        [ResponseCache(Duration = 60)] // seconds
        public async Task<IActionResult> GetMusicAlbumsAsync(string query = null)
        {
            var musicAlbums = await _musicAlbumService.GetMusicAlbumsAsync();

            if (!String.IsNullOrWhiteSpace(query))
                musicAlbums = musicAlbums.Where(m => m.Title.Contains(query));

            return Ok(musicAlbums);
        }

        // GET /api/musicalbums/1
        [HttpGet("{id}", Name = "GetMusicAlbum")]
        [ResponseCache(Duration = 60)]
        public async Task<IActionResult> GetMusicAlbumAsync(int id)
        {
            var musicAlbum = await _musicAlbumService.GetMusicAlbumAsync(id);

            if (musicAlbum == null)
                return NotFound();

            return Ok(musicAlbum);
        }

        // POST /api/musicalbums
        [HttpPost]
        public async Task<IActionResult> CreateMusicAlbumAsync(MusicAlbumDto musicAlbumDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            musicAlbumDto.Id = await _musicAlbumService.AddMusicAlbumAsync(musicAlbumDto);

            return CreatedAtAction("GetMusicAlbum", new { id = musicAlbumDto.Id }, musicAlbumDto);
        }

        // PUT /api/musicalbums/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusicAlbumAsync(int id, MusicAlbumDto musicAlbumDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != musicAlbumDto.Id)
                return BadRequest();

            try
            {
                await _musicAlbumService.UpdateMusicAlbumAsync(musicAlbumDto);
                return Ok(musicAlbumDto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _musicAlbumService.IsMusicAlbumExists(id))
                    return NotFound();
                else
                    return BadRequest();
            }
        }

        // DELETE /api/musicalbums/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusicAlbumAsync(int id)
        {
            if (!await _musicAlbumService.IsMusicAlbumExists(id))
                return NotFound();

            await _musicAlbumService.DeleteMusicAlbumAsync(id);
            return Ok();
        }
    }
}
