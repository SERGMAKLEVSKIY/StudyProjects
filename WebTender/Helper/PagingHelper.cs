using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebTender.Models;

namespace WebTender.Helper
{
    public static class PagingHelper
    {

        public static MvcHtmlString PageLinks(this HtmlHelper html,
      int PageNumber, Func<int, string> pageUrl, PageInfo pageInfo)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                // если текущая страница, то выделяем ее,
                // например, добавляя класс
                if (i == PageNumber)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }

    }
}