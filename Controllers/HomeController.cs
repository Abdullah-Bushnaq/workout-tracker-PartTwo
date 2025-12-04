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
            // create a session id
            SetSession("id", Guid.NewGuid().ToString());
            // Check if the user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                // User is logged in, get their username
                SetCookies("userName", User.Identity.Name);
                // create a session with username
                SetSession("username", User.Identity.Name);
            }
            else
            {
                // User is not logged in, set a cookie with "Guest"
                SetCookies("userName", "guest");
                // create a session with username
                SetSession("username", "guest");
            }
            // Get the broswer type
            SetCookies("broswerName", Request.Headers["User-Agent"].ToString());
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
        public IActionResult SetCookies(string cookieName, string cookieValue)
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(15),  // «·ﬂÊﬂÌ“  ‰ ÂÌ »⁄œ 15 ÌÊ„
                HttpOnly = true,                     //  „‰⁄ «·Ê’Ê· „‰ JavaScript
                Secure = true,                       //  ” Œœ„ https
                SameSite = SameSiteMode.Strict       //  „‰⁄ ÂÃ„«  CSRF
            };

            Response.Cookies.Append(cookieName, cookieValue, options);
            return Ok("Cookies has been set.");
        }

        public IActionResult SetSession(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
            return Ok("Session value has been set successfully!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
