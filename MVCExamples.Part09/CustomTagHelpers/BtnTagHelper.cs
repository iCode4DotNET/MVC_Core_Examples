using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCExamples.Part09.CustomTagHelpers;


[HtmlTargetElement("button", Attributes = "my-custom-color")]
public class MyCustomBtn : TagHelper
{
    public MyCustomBtn()
    {
       MyCustomColor = "info";
    }

    public string MyCustomColor { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.SetAttribute("class", $"btn btn-{MyCustomColor}");
    }
}