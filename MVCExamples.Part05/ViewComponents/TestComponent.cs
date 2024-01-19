using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part05.ViewComponents
{
    public class Test : ViewComponent
    {
        //https://learn.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-8.0

        //The view 'Components/Test/Test2' was not found.The following locations were searched:
    //  /Views/Home/Components/Test/Test2.cshtml
    // /Views/Shared/Components/Test/Test2.cshtml

        public IViewComponentResult Invoke()
        {
            return View("Test2");
        }

    }
}
