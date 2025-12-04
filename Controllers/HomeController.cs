using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using workout_tracker.Models;

namespace workout_tracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        // Added About action method Â–Ì ⁄‘«‰ »⁄œ «·—«Ê Ì‰ﬁ ÌÃÌ ··ﬂ‰ —Ê· ÊÌœÊ— Â· ›Ì «ﬂ‘‰ »«·«”„ Â–« ⁄‘«‰ Ì”ÊÌ ·Â ›ÌÊ ø 
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
