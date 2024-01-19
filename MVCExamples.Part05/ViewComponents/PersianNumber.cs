using Microsoft.AspNetCore.Mvc;

namespace MVCExamples.Part05.ViewComponents
{
    public class PersianNumber : ViewComponent
    {
        public IViewComponentResult Invoke(int number)
        {
            //Biz

            if (number == 0) 
            { 
            }

            if (number > 999999999)
            {
                number -= 100000;
            }



            return View(viewName:"PersianNumber", model: number);
        }
    }
}
