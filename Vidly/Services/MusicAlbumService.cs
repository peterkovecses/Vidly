using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Vidly.DTOs;
using Vidly.Interfaces;
using Vidly.Models;

namespace Vidly.Services
{
    public class MusicAlbumService : IMusicAlbumService
    {
        private readonly VidlyDbContext _dbContext;
        private readonly IMapper _mapper;

        public MusicAlbumService(VidlyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        private readonly Expression<Func<MusicAlbum, MusicAlbumDto>> _musicAlbumSelector = ma => new MusicAlbumDto
        {
            Id = ma.Id,
            Artist = ma.Artist,
            Title = ma.Title,
            DateAdded = ma.DateAdded,
            ReleaseDate = ma.ReleaseDate,
            NumberInStock = ma.NumberInStock,
            GenreId = ma.GenreId,
            Genre = new MusicGenreDto { Id = ma.GenreId, Name = ma.Genre.Name }
        };

        public async Task<IEnumerable<MusicAlbumDto>> GetMusicAlbumsAsync()
        {
            return await _dbContext.MusicAlbums.Include(ma => ma.Genre).Select(_musicAlbumSelector).ToListAsync();
        }

        public async Task<MusicAlbumDto> GetMusicAlbumAsync(int id)
        {
            return await _dbContext.MusicAlbums.Where(ma => ma.Id == id).Select(_musicAlbumSelector).SingleOrDefaultAsync();
        }

        public async Task<int> AddMusicAlbumAsync(MusicAlbumDto musicAlbumDto)
        {
            var musicAlbum = _mapper.Map<MusicAlbumDto, MusicAlbum>(musicAlbumDto);

            _dbContext.MusicAlbums.Add(musicAlbum);
            await _dbContext.SaveChangesAsync();

            return musicAlbum.Id;
        }

        public async Task UpdateMusicAlbumAsync(MusicAlbumDto musicAlbumDto)
        {
            var musicAlbumInDb = await _dbContext.MusicAlbums.SingleAsync(ma => ma.Id == musicAlbumDto.Id);      

            _mapper.Map(musicAlbumDto, musicAlbumInDb);

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMusicAlbumAsync(int id)
        {
            var musicAlbumInDb = await _dbContext.MusicAlbums.SingleAsync(ma => ma.Id == id);

            _dbContext.MusicAlbums.Remove(musicAlbumInDb);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsMusicAlbumExists(int id)
        {
            return await _dbContext.MusicAlbums.AnyAsync(ma => ma.Id == id);
        }
    }
}
