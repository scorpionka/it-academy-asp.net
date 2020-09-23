using HW4.Client.Models.ViewModels;
using HW4.Client.PresentationServices.Interfaces;
using System.Web.Mvc;

namespace HW4.Client.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService presentationService;

        public UserController(IUserPresentationService presentationService)
        {
            this.presentationService = presentationService;
        }

        public ActionResult Index()
        {
            return View(presentationService.AllUsers());
        }

        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(presentationService.AllCountries(), "Id", "Name");
            ViewBag.Cities = new SelectList(presentationService.AllCities(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateUserViewModel user)
        {
            presentationService.AddUser(user);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            EditUserViewModel user = presentationService.GetEditUserView(id);
            ViewBag.Countries = new SelectList(presentationService.AllCountries(), "Id", "Name");
            ViewBag.Cities = new SelectList(presentationService.AllCities(), "Id", "Name");
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                presentationService.EditUser(user);
                return RedirectToAction("Index");
            }
            ViewBag.Countries = new SelectList(presentationService.AllCountries(), "Id", "Name");
            ViewBag.Cities = new SelectList(presentationService.AllCities(), "Id", "Name");
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            DeleteUserViewModel user = presentationService.GetDeleteUserView(id);
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                presentationService.DeleteUser(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}