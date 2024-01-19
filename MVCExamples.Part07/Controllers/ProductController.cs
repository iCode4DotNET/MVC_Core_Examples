using Microsoft.AspNetCore.Mvc;

namespace Part01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Detail(int id)
        {
            ViewBag.ID = id;
            return View();
        }


    }
}
