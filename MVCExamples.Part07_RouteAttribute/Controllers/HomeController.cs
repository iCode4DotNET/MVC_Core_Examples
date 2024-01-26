using Microsoft.AspNetCore.Mvc;
using WebExt;
namespace MVCExamples.Part07_RouteAttribute.Controllers;


//https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-8.0

public class HomeController : ControllerBase
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    [Route("Home/Index/{id?}")]
    public IActionResult Index(int? id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }


    [Route("Home/About")]
    [Route("Home/About/{id?}")]
    public IActionResult About(int? id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [Route("HomeAlone")]
    [Route("HomeAlone/Index")]
    [Route("HomeAlone/Index/{id?}")]
    public IActionResult MyIndex(int? id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [Route("HomeAlone/About")]
    [Route("HomeAlone/About/{id?}")]
    public IActionResult MyAbout(int? id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [Route("Contact")]
    [Route("[controller]/[action]")]
    public IActionResult Contact()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

   
}



[Route("[controller]/[action]")]
public class PersonController : ControllerBase
{
    public IActionResult Index()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    public IActionResult About()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    public IActionResult Blog()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    [Route("/people/{page}")]
    public IActionResult List(int page)
    {
        return ControllerContext.MyDisplayRouteInfo(page);
    }
}

public class AdminController : ControllerBase
{
    [Route("secureadmin/a1/b2/c3/d4/")]
    public IActionResult Index()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }
}


[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]   // GET /api/test
    public IActionResult ListProducts()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    [HttpGet("{id}")]   // GET /api/test/xyz
    public IActionResult GetProduct(string id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [HttpGet("int/{id:int}")] // GET /api/test/int/3
    public IActionResult GetIntProduct(int id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [HttpGet("int2/{id}")]  // GET /api/test/int2/3
    public IActionResult GetInt2Product(int id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }
}


[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet("/goods")]
    public IActionResult ListProducts()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    [HttpPost("/goods")]
    public IActionResult CreateProduct(object myProduct)
    {
        return ControllerContext.MyDisplayRouteInfo(myProduct.ToString());
    }
}