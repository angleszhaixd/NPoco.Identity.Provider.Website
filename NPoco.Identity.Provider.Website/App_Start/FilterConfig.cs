using System.Web;
using System.Web.Mvc;

namespace NPoco.Identity.Provider.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
