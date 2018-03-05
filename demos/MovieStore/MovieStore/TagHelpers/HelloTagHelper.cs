namespace MovieStore.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;

    [HtmlTargetElement("hi")]
    public class HelloTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            output.Attributes.Add("id", context.UniqueId);

            output.PreContent.SetContent("Hello ");
            output.PostContent.SetContent($", time is now: {DateTime.Now.ToString("HH: mm")}");
        }
    }
}
