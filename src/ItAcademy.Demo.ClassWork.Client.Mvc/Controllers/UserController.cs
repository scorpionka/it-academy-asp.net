using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService userPresentationService;

        public UserController(IUserPresentationService userPresentationService)
        {
            this.userPresentationService = userPresentationService;
        }

        public JsonResult Index(string name)
        {
            return Json(userPresentationService.GetByNameWithRole(name), JsonRequestBehavior.AllowGet);
        }
    }
}