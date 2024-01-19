using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part01.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Get(int id)
        //{
        //    ViewBag.ID = id;
        //    return View();
        //}

        public IActionResult Get(string category,string title)
        {
            ViewBag.Category = category;
            ViewBag.Title = title;
            return View();
        }
    }
}