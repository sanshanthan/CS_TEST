using System.Web;
using System.Web.Mvc;

namespace DI_inMVC_usingUnityIoCContainer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
