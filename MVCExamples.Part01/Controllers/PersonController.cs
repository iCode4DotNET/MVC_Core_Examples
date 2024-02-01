using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part01.Controllers
{
    //public class PersonController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}

    //public class Person : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}

    //public class PersonController2 : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}

    //public class PersonController //: Controller
    //{
    //    //public IActionResult Index()
    //    //{
    //    //    return View();
    //    //}

    //    public string Index()
    //    {
    //        return "OK";
    //    }
    //}

    //public class PersonController : ControllerBase
    //{
    //    public IActionResult Index()
    //    {
    //        //return View();
    //        return Content("Controller Base : Index");
    //    }
    //}

    //public class PersonController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    [NonAction]
    //    public IActionResult MyPrivateIndex()
    //    {
    //        return Content(nameof(MyPrivateIndex));
    //    }
    //}


    //[NonController]
    //public class PersonController 
    //{
    //    public string Index()
    //    {
    //        return "index !!";
    //    }
    //}


    /// <summary>
    /// Best Practice
    /// </summary>
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person(1, "سروش", "صدر");

            ViewData[SadrTools.Utility.StaticValues.ViewData.ID] = person.ID;
            ViewData[SadrTools.Utility.StaticValues.ViewData.FirstName] = person.FirstName;
            ViewData[SadrTools.Utility.StaticValues.ViewData.LastName] = person.LastName;
            ViewData[SadrTools.Utility.StaticValues.ViewData.Person] = person;
            return View();
        }

        public IActionResult Index2()
        {
            var products = SampleData.Shopping.GetProducts();
            return View(products);
        }

        

    }
}

