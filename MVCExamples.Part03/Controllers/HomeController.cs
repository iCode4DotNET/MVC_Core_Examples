using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part03.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Index2()
    {
        var person = new Person(1,"سروش","صدر")
        {
            Note = "امیدوارم از این آموزش نهایت استفاده را ببرید",
            IsAdmin = true
        };
        return View(person); 
    }

    public IActionResult Index3()
    {
        var person = new Person(1, "سروش", "صدر")
        {
            Note = "امیدوارم از این آموزش نهایت استفاده را ببرید",
            IsAdmin = true
        };
        return View(person);
    }
}
