﻿using System;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace BlogSite.Core.Extensions
{
    public static class HtmlExtensions {
        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propertyAlias, bool fluidImages) {
            if (fluidImages)
            {
                return html.Raw(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace(oldValue:"<img ", newValue:"<img class=\"img-fluid\" "));
            }
            else
            {
                return html.GetGridHtml(contentItem, framework: propertyAlias, propertyAlias: framework);
            }
        }
    }
}
