using System.Web.Mvc;
using System.Web.Security;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class AccountController : Controller
    {
        [HttpGet]
        public virtual ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(string username, string password,string returnUrl)
        {
            // validate

            FormsAuthentication.SetAuthCookie(username, true);

            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction(MVC.Home.Index());
        }

        public virtual ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction(MVC.Home.Index());
        }
    }
}