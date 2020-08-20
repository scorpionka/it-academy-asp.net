using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters
{
    public class CustomActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine($"CustomActionFilter: OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine($"CustomActionFilter: OnActionExecuting");
        }
    }
}