using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly VidlyDbContext _dbContext;

        public CustomersController(VidlyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var customers = _dbContext.Movies.ToList();
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _dbContext.Movies.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }
    }
}
