using AutoMapper;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MusicAlbum, MusicAlbumDTO>();
            CreateMap<MusicAlbumDTO, MusicAlbum>();
        }
    }
}
