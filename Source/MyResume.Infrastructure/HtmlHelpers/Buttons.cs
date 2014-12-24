namespace MyResume.Infrastructure.HtmlHelpers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class Buttons
    {
        private const string modalEventClass = "showModal";

        public static MvcHtmlString CreateButton(this HtmlHelper htmlHelper, string text = null, bool isModal = false)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "Create";
            }

            return PrimaryButton(htmlHelper, text, "Create", null, isModal);
        }

        public static MvcHtmlString CreateButtonModal(this HtmlHelper htmlHelper, string text = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "Create";
            }

            return PrimaryButton(htmlHelper, text, "Create");
        }

        public static MvcHtmlString EditButton(this HtmlHelper htmlHelper, int id, string text = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "Edit";
            }

            return PrimaryButton(htmlHelper, text, "Edit", new { id = id });
        }

        public static MvcHtmlString DeleteButton(this HtmlHelper htmlHelper, int id, string text = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "Delete";
            }

            return DangerButton(htmlHelper, text, "Delete", new { id = id });
        }

        public static MvcHtmlString PrimaryButton(
            this HtmlHelper htmlHelper,
            string text,
            string action,
            object routeValues = null,
            bool isModal = false)
        {
            var classValues = 
                string.Format("btn btn-primary {0}", isModal == true ? modalEventClass : string.Empty);

            return htmlHelper.ActionLink(
                text,
                action,
                routeValues,
                new { @class = classValues});
        }

        public static MvcHtmlString DangerButton(
            this HtmlHelper htmlHelper,
            string text,
            string action,
            object routeValues = null)
        {
            return htmlHelper.ActionLink(
                text,
                action,
                routeValues,
                new { @class = "btn btn-danger" });
        }

        public static MvcHtmlString SuccessButton(
            this HtmlHelper htmlHelper,
            string text,
            string action,
            object routeValues = null)
        {
            return htmlHelper.ActionLink(
                text,
                action,
                routeValues,
                new { @class = "btn btn-success" });
        }

        public static MvcHtmlString SubmitButton(this HtmlHelper helper, string value, object htmlAttributes = null)
        {
            var submitButton = new TagBuilder("input");
            submitButton.AddCssClass("btn btn-primary");
            submitButton.Attributes.Add("type", "submit");
            submitButton.Attributes.Add("value", value);
            submitButton.ApplyAttributes(htmlAttributes);
            return new MvcHtmlString(submitButton.ToString());
        }

        public static MvcHtmlString DefaultButton(
            this HtmlHelper htmlHelper,
            string text,
            string action,
            object routeValues = null)
        {
            return htmlHelper.ActionLink(
                text,
                action,
                routeValues,
                new { @class = "btn btn-default" });
        }

        private static void ApplyAttributes(this TagBuilder tagBuilder, object htmlAttributes)
        {
            if (htmlAttributes != null)
            {
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                tagBuilder.MergeAttributes(attributes);
            }
        }
    }
}
