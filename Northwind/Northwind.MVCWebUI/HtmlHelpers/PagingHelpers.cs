using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Northwind.MVCWebUI.Models;

namespace Northwind.MVCWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pageInfo)
        {
            int totalPage = (int)Math.Ceiling((decimal)pageInfo.TotalItems / pageInfo.ItemsPerPage);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= totalPage; i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", $"/Product/Index/?page={i}&category={pageInfo.CurrentCategory}");
                tagBuilder.InnerHtml = i.ToString();

                if (pageInfo.CurrentPage == i)
                {
                    tagBuilder.AddCssClass("selected");
                }

                stringBuilder.Append(tagBuilder);
            }

            return MvcHtmlString.Create(stringBuilder.ToString());
        }
    }
}