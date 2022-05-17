using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Interfaces
{
    public interface IMusicAlbumService
    {
        Task<IEnumerable<MusicAlbumDto>> GetMusicAlbumsAsync();

        Task<MusicAlbumDto> GetMusicAlbumAsync(int id);

        Task<int> AddMusicAlbumAsync(MusicAlbumDto musicAlbumDto);

        Task UpdateMusicAlbumAsync(MusicAlbumDto musicAlbumDto);

        Task DeleteMusicAlbumAsync(int id);

        Task<bool> IsMusicAlbumExists(int id);
    }
}
