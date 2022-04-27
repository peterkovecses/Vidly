using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly VidlyDbContext _dbContext;

        public MoviesController(VidlyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var movies = _dbContext.Movies.ToList();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _dbContext.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);
        }
    }
}
