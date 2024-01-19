using Microsoft.AspNetCore.Mvc;


namespace Part04_Area.Areas.HR.Controllers
{
    [Area("HR")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Manager2()
        {
            return View();
        }
    }
}
