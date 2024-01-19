using Microsoft.AspNetCore.Mvc;


namespace Part04_Area.Areas.HR.Controllers
{
    [Area("HR")]
    public class HrTaskController
    {
        public string Index()
        {
            return "HR ..........";
        }
    }
}
