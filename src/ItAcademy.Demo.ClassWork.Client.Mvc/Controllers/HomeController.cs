using System;
using System.Threading;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    [Authorize]
    public partial class HomeController : Controller
    {
        [AllowAnonymous]
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}