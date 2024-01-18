using Microsoft.AspNetCore.Mvc;
using SadrTools.Utility;

namespace MVCExamples.Part02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome dear user !!";
            ViewData[StaticValues.ViewData.Welcome] = "salam chetori?";
            TempData[StaticValues.TempData.Contact] = "Zang bEzan !!";

            return View();
        }

        public IActionResult Privacy()
        {
            var welcome = ViewBag.Welcome;
            var welcome2 = ViewData[StaticValues.ViewData.Welcome];
            var call = TempData[StaticValues.TempData.Contact];

            Console.WriteLine($"{nameof(Privacy)} : {welcome ?? "null"}");
            Console.WriteLine($"{nameof(Privacy)} : {welcome2 ?? "null"} ");
            Console.WriteLine($"{nameof(Privacy)} : {call ?? "null"}");

            ViewData[StaticValues.ViewData.Security] = "All Secure !!";

            return View();
        }

        
        //public IActionResult Contact()
        //{
        //    var call = TempData[StaticValues.TempData.Contact];

        //    Console.WriteLine($"{nameof(Contact)} : {call ?? "null"}");

        //    TempData[StaticValues.TempData.Contact] = "با ما تماس بگیرید";

        //    TempData.Keep();

        //    return View();
        //}

        public IActionResult About()
        {    
            var contact = TempData[StaticValues.TempData.Contact];

            Console.WriteLine($"{nameof(About)} : {contact ?? "null"}");

            return View();
        }

        
        [ActionName(name: "contact-us")]
        public IActionResult Contact()
        {
            var call = TempData[StaticValues.TempData.Contact];

            Console.WriteLine($"{nameof(Contact)} : {call ?? "null"}");

            TempData[StaticValues.TempData.Contact] = "با ما تماس بگیرید";

            TempData.Keep();

            //return View(viewName:"/views/home/contact");
            return View(viewName: "/views/home/contact.cshtml");

        }

    }
}
