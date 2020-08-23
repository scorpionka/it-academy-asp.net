using System.Diagnostics;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters
{
    public class CustomResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.RequestContext.HttpContext
                .Response.Write("<p>CustomResultFilter: OnResultExecuted</p>");

            Debug.WriteLine($"CustomResultFilter: OnResultExecuted");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.RequestContext.HttpContext
                .Response.Write("<p>CustomResultFilter: OnResultExecuting</p>");

            Debug.WriteLine($"CustomResultFilter: OnResultExecuting");
        }
    }
}