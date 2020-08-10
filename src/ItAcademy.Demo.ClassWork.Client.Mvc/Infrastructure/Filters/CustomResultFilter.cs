using System.Diagnostics;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters
{
    public class CustomResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine($"CustomResultFilter: OnResultExecuted");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine($"CustomResultFilter: OnResultExecuting");
        }
    }
}