using System.Web;
using System.Web.Mvc;

namespace SkillTree_MVC5_HW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
