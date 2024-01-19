using Microsoft.AspNetCore.Mvc;

namespace Part01.Controllers
{
    public class AdminController : Controller
    {

        [HttpGet(template:"AboutAdmin")]
        public string Abouts()
        {
            return "AboutAdmin ==> Abouts";
        }

        [HttpGet(template:"Site/Admin/Page/About")]
        public string About()
        {
            return "Site/Admin/Page/About ==> About";
        }


        //[Route()] ToDo 
        public string About2()
        {
            return "Site/Admin/Page/About ==> About";
        }
    }
}

