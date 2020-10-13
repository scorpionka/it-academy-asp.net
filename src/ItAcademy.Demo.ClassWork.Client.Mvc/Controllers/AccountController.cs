using System.Web.Mvc;
using System.Web.Security;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class AccountController : Controller
    {
        [HttpGet]
        public virtual ActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(string username, string password)
        {
            // validate

            FormsAuthentication.SetAuthCookie(username, true);

            var returnUrl = TempData["returnUrl"] as string;

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