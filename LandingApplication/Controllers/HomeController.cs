using Microsoft.AspNetCore.Mvc;

namespace LandingApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
