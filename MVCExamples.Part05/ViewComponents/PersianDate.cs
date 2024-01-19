using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part05.ViewComponents;

public class PersianDate : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return  View("PersianDate");
    }
}

