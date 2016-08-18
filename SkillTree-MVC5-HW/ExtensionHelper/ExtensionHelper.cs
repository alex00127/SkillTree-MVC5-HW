using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC5_HW.Models.ViewModels;

namespace SkillTree_MVC5_HW.ExtensionHelper
{
    public static class ExtensionHelper
    {
        public static MvcHtmlString SetColorByCategory(this HtmlHelper helper,CategoryEnum category )
        {

            return MvcHtmlString.Create(StringColor(category.ToString(), category == CategoryEnum.Expand ? "red" : "blue"));

        }

        private static string StringColor(string category, string color)
        {
            return $"<font color='{color}'>{category}</font>";
        }
    }
}