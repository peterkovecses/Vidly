using Microsoft.AspNetCore.Mvc.Rendering;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public SelectList GenresSelectList { get; set; }
    }
}
