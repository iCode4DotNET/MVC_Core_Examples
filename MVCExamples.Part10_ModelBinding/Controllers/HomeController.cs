using Microsoft.AspNetCore.Mvc;
using MVCExamples.Part10_ModelBinding.Models;
using System.Diagnostics;
using SadrTools.Extension;
using Microsoft.AspNetCore.Http.HttpResults;
using Entities.ModelBinding.Simple;

namespace MVCExamples.Part10_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetByID(int id)
        {
            var url = Url.ActionLink(Url.Action(nameof(Index))) ?? "Url is Null";

            var query = Request.QueryString.Value.IsNullOrEmpty() ? "Query String is Null" : Request.QueryString.Value;

            var queryID = Request.Query["id"].ToString().IsNullOrEmpty() ? "Query[\"id\"] is Null" : Request.Query["id"].ToString();

            return $"""Url = {url} ID = {id} Query String = {query} Query["id"] = {queryID}""";
        }

        public string Search([FromRoute] int id)
        {
            var url = Url.ActionLink(Url.Action(nameof(Index))) ?? "Url is Null";

            var query = Request.QueryString.Value.IsNullOrEmpty() ? "Query String is Null" : Request.QueryString.Value;

            var queryID = Request.Query["id"].ToString().IsNullOrEmpty() ? "Query[\"id\"] is Null" : Request.Query["id"].ToString();

            return $"""From Route ===> Url = {url} ID = {id} Query String = {query} Query["id"] = {queryID}""";
        }

        public string Search2([FromQuery] int id)
        {
            var url = Url.ActionLink(Url.Action(nameof(Index))) ?? "Url is Null";

            var query = Request.QueryString.Value.IsNullOrEmpty() ? "Query String is Null" : Request.QueryString.Value;

            var queryID = Request.Query["id"].ToString().IsNullOrEmpty() ? "Query[\"id\"] is Null" : Request.Query["id"].ToString();

            return $"""FromQuery ===> Url = {url} ID = {id} Query String = {query} Query["id"] = {queryID}""";
        }

        public JsonResult GetHeader([FromHeader] string accept)
        {
            accept += "fROM hEADER : ";
            return Json(accept);
        }

        public IActionResult GetHeader2([FromHeader(Name = "Accept-Language")] string data)
        {
            return Json(data);
        }

        public IActionResult GetHeader3([FromHeader(Name = "User-Agent")] string data)
        {
            return Json(data);
        }

        [HttpPost]
        public string Test1([FromBody] object data1)
        {
            //https://jsoneditoronline.org/#left=local.gomade

            return $"From Body : {data1} !";
        }


        [AcceptVerbs("GET","POST","PUT")]
        public string Test2(object data1)
        {
            return "";
        }
    }
}