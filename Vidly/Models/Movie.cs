using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
