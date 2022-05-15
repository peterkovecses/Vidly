using Microsoft.AspNetCore.Mvc;

namespace Vidly.Controllers
{
    public class MusicAlbumsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
