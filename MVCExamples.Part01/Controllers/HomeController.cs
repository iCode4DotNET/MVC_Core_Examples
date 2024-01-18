using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part01.Controllers
{
    public class HomeController : Controller
    {
        public string Hello()
        {
            return """Welcome from "Hello Action" """;
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }


        public List<long> GetNumbers()
        {
            List<long> numbers = [5454, 35, 435, 43, 54, 35, 34, 53, 45, 34];
            return numbers;
        }

        public IActionResult Dotin()
        {
            ViewData["MyTest"] = "View Data Test !!";

            //ViewBag = "Error";

            ViewBag.MyViewBag = "salam";

            ViewBag.MyTest = "BREAK !!";

            #region [ dynamic example ]

            /*
            var x = 123;
            //x = "salam"; Error

            dynamic abc = 123.567;

            abc = "salam";

            abc = DateTime.Now; 
            */

            #endregion




            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
