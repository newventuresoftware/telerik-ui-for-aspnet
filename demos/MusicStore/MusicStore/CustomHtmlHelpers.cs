namespace MusicStore
{
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class CustomHtmlHelpers
    {
        public static IHtmlString MyList(this HtmlHelper helper, IEnumerable<string> items, bool ordered = false)
        {
            var list = new TagBuilder(ordered ? "ol" : "ul");
            
            foreach (var item in items)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(item);
                list.InnerHtml += li.ToString();
            }
            
            return new MvcHtmlString(list.ToString());
        }

        public static IHtmlString MyButton(this HtmlHelper helper, string text, object attributes = null)
        {
            var button = new TagBuilder("button");
            button.SetInnerText(text);

            // converts an anonymous object to a dictionary
            button.MergeAttributes(new RouteValueDictionary(attributes));
            return new MvcHtmlString(button.ToString());
        }
    }
}