using System.Web;
using System.Web.Mvc;

namespace ASP_Net_MVC_Lab5_MvcCreditApp1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
