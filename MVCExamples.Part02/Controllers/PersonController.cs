using Microsoft.AspNetCore.Mvc;
using SadrTools.Utility;

namespace MVCExamples.Part02.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var call = TempData[StaticValues.TempData.Contact];

            Console.WriteLine($"Tanx To Hossein : {nameof(Index)} : {call} :-)");

            return View();
        }
    }
}
