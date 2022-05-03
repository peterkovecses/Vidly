using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var movies = _dbContext.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _dbContext.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);
        }
    }
}
