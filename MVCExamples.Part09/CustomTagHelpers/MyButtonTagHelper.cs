using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCExamples.Part09.CustomTagHelpers;

/// <summary>
/// من Button
/// </summary>
public class MyButtonTagHelper : TagHelper
{
    /// <summary>
    /// نوع پیشفرض submit
    /// </summary>
    public string BtnType { get; set; } = "Submit";
    
    /// <summary>
    /// رنگ پیش فرض primary
    /// </summary>
    public string BtnColor { get; set; } = "primary";

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.SetAttribute("class", $"btn btn-{BtnColor}");
        output.Attributes.SetAttribute("type", BtnType);
        output.Content.SetContent(BtnType.ToString().ToLower() == "submit" ? "افزودن" : "انصراف");
    }
}
