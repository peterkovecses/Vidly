using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MusicAlbumDTO
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [MusicAlbumMaxReleaseDate]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte GenreId { get; set; }
        public MusicGenreDTO Genre { get; set; }
    }
}
