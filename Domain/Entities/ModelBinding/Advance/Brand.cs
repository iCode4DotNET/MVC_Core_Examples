using Microsoft.AspNetCore.Http;

namespace Entities.ModelBinding.Advance;

public class Brand
{

    public Brand()
    {
        Title = string.Empty;
        Image = null!; 
    }

    /// <summary>
    /// شناسه برند
    /// </summary>

    //[BindNever] // requires : microsoft.aspnetcore.mvc.core
    public int ID { get; set; }

    /// <summary>
    /// عنوان برند
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// تصویر برند
    /// </summary>
    public IFormFile Image { get; set; }
}
