using Microsoft.AspNetCore.Mvc;
using MVCExamples.Part04.Models;
using System.Diagnostics;
namespace MVCExamples.Part04.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //throw new Exception("جهت تست");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}