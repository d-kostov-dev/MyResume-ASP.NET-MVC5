namespace MyResume.Infrastructure.HtmlHelpers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class MenuLinkHelper
    {
        public static MvcHtmlString MenuLink(this HtmlHelper helper, string text, string action, string controller)
        {
            var routeData = helper.ViewContext.RouteData.Values;

            var currentController = routeData["controller"];
            var currentAction = routeData["action"];
            
            var listItem = new TagBuilder("li");

            if (string.Equals(action, currentAction as string, StringComparison.OrdinalIgnoreCase) &&
               string.Equals(controller, currentController as string, StringComparison.OrdinalIgnoreCase))
            {
                listItem.AddCssClass("active");
            }

            listItem.InnerHtml += helper.ActionLink(text, action, controller);

            return new MvcHtmlString(listItem.ToString());
        }
    }
}
