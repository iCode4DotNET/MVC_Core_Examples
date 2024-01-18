using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part00.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello";
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}
