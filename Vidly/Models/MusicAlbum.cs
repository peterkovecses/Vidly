using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MusicAlbum
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [MusicAlbumMaxReleaseDate]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte GenreId { get; set; }
        public MusicGenre Genre { get; set; }
    }
}
