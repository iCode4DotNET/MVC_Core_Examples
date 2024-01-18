using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Tools.Extensions;

public static class HtmlExt
{
    /// <summary>
    /// نمایش تصویر
    /// </summary>
    public static IHtmlContent Image(this IHtmlHelper helper, string id, string src, string alt, int height, int width)
    {
        var builder = new TagBuilder("img");
        builder.MergeAttribute(key:"id",value: id);
        builder.MergeAttribute("src", src);
        builder.MergeAttribute("alt", alt);
        builder.MergeAttribute("title", alt);
        builder.MergeAttribute("height", height.ToString());
        builder.MergeAttribute("width", width.ToString());
        return builder.RenderSelfClosingTag();
    }
}