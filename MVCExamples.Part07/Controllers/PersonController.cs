using Microsoft.AspNetCore.Mvc;

namespace Part01.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get(int id)
        {
            ViewBag.ID = id;
            return View();
        }




        public IActionResult GetByName(int id, string name)
        {
            // زمانی که از طریق روتینگ فقط آیدی را میتوان ارسال کرد
            // باقی موارد با استفاده از
            //querystring ارسال میشوند

            var queryString = HttpContext.Request.QueryString.Value;
            var nameValue = HttpContext.Request.Query["name"].ToString();

            ViewBag.ID = id;
            ViewBag.Name = name;
            return View();
        }

        public IActionResult GetByFullName(int id, string name, string family)
        {
            var queryString = HttpContext.Request.QueryString.Value;
            var familyValue = HttpContext.Request.Query["family"].ToString();

            // http://localhost:64955/person/getbyfullname/10/soroush/sadr

            ViewBag.ID = id;
            ViewBag.Name = name;
            ViewBag.Family = family;

            return View();
        }

        public IActionResult Search(string query)
        {
            var q = HttpContext.Request.Query["query"].ToString();

            var x = HttpContext.Request.QueryString.Value;

            return View();
        }
    }
}
