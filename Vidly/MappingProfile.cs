using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MusicAlbum, MusicAlbumDto>();
            CreateMap<MusicAlbumDto, MusicAlbum>();
            CreateMap<MusicGenre, MusicGenreDto>();
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
        }
    }
}
