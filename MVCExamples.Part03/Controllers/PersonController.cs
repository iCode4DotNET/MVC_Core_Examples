using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVCExamples.Part03.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        var people = SampleData.Personel.GetPeople();
        return View(people);
    }

    public IActionResult Index2()
    {
        var people = SampleData.Personel.GetPeople();
        return View(people);
    }

    public IActionResult Detail(int id)
    {
        var person = SampleData.Personel.GetPeople().Where(p => p.ID == id).SingleOrDefault();

        if (person == null)
        {

        }

        return View(person);

    }

    public JsonResult Index3()
    {
        var people = SampleData.Personel.GetPeople();
        return Json(people);
    }
}
