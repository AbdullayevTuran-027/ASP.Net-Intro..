using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
