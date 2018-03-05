namespace MovieStore.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Collections.Generic;
    
    [HtmlTargetElement("my-list")]
    public class ListTagHelper : TagHelper
    {
        [HtmlAttributeName("items")]
        public IEnumerable<object> Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.TagMode = TagMode.StartTagAndEndTag;

            foreach (var item in this.Items)
            {
                output.Content.AppendHtml($"<li>{item}</li>");
            }
        }
    }
}
