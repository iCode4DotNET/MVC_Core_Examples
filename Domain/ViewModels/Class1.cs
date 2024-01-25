using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace ViewModels
{
    public class BrandAddViewModel
    {
        [DisplayName(displayName:"نام فایل")]
        public string Title { get; set; }

        public string Description { get; set; }

        public IFormFile File { get; set; }
    }


    public class BrandEditViewModel : BrandAddViewModel
    {
        public int ID { get; set; }
    }

    public class BrandComboViewModel
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
    }



}
