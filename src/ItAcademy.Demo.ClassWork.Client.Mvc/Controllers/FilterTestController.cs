using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.ActionFilterTest;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public class FilterTestController : Controller
    {
        [CustomResultFilter]
        public ActionResult Index()
        {
            return View(new Sum { Value = 3 });
        }

        [CustomActionFilter]
        public ActionResult Sum(int a, int b)
        {
            return Json(new Sum { Value = a + b }) ;
        }

        public ActionResult TestException()
        {
            throw new ApplicationException("IT Academy");
        }

        [OutputCache(Duration = 600)]
        public ActionResult GetCurrentTime()
        {
            return Content(DateTime.Now.ToString());
        }

        public ActionResult GetCurrentTimeNoCache()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}