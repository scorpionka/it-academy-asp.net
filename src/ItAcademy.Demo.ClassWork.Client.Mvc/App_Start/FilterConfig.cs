using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
