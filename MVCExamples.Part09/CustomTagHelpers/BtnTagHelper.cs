using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCExamples.Part09.CustomTagHelpers;


/// <summary>
/// Button من 
/// </summary>
[HtmlTargetElement("button", Attributes = "my-custom-color")]
public class MyCustomBtn : TagHelper
{
    public MyCustomBtn()
    {
       MyCustomColor = "info";
    }

    /// <summary>
    /// رنگ بر اساس استاندارد های بوت استرپ
    /// </summary>
    public string MyCustomColor { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.SetAttribute("class", $"btn btn-{MyCustomColor}");
    }
}

// https://learn.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/authoring?view=aspnetcore-8.0
