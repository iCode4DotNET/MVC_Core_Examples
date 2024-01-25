using Entities.ModelBinding.Advance;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace MVCExamples.Part10_ModelBinding.Controllers
{
    public class BrandController : Controller
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


        //[HttpPost]
        //public JsonResult Create(Brand brand)
        //{
        //    return Json(brand);
        //}


        //[HttpPost]
        //public JsonResult Create([Bind(nameof(Brand.Title), nameof(Brand.Image))] Brand brand)
        //{
        //    return Json(brand);
        //}


        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(BrandAddViewModel brand)
        {
            return View();
        }
    }
}
