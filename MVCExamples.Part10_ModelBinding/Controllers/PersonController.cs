using Entities.ModelBinding.Simple;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

namespace MVCExamples.Part10_ModelBinding.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(Person person, int phoneIndex)
        {
            // Add logic for handling phones using the phoneIndex parameter
            return Json(person);
        }

        [HttpGet]
        public IActionResult CreateWithAddress()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateWithAddress(Person person)
        {
            return Json(person);
        }

        [HttpGet]
        public IActionResult CreateWithAddressAndRole()
        {
            var data = Enum.GetNames(typeof(EnRole));
            Microsoft.AspNetCore.Mvc.Rendering.SelectList roles = new(items: data);

            ViewBag.RoleEnum = roles;

            return View();
        }

        [HttpPost]
        public IActionResult CreateWithAddressAndRole(Person person)
        {
            if (ModelState.IsValid == false)
            {
                // Add appropriate error messages or handling
                ViewBag.RoleEnum = new SelectList(Enum.GetNames(typeof(EnRole)));
                return View(person);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult CreateWithAddressAndRoleAndFavorites()
        {
            var data = Enum.GetNames(typeof(Entities.ModelBinding.Advance.EnRole));
            Microsoft.AspNetCore.Mvc.Rendering.SelectList roles = new(items: data);
            ViewBag.RoleEnum = roles;
            return View();
        }

        [HttpPost]
        public JsonResult CreateWithAddressAndRoleAndFavorites(Entities.ModelBinding.Advance.Person person)
        {
            return Json(person);
        }

        public IActionResult GetFavoritesSection()
        {
            return PartialView("_FavoritePartial");
        }

        public IActionResult GetPhonesSection(int id)
        {
            var data = Enum.GetNames(typeof(Entities.ModelBinding.Advance.EnPhoneType));
            Microsoft.AspNetCore.Mvc.Rendering.SelectList phoneType = new(items: data);
            ViewBag.PhoneType = phoneType;
            ViewBag.Index = id;
            return PartialView("_PhonesPartial");
        }
    }
}
