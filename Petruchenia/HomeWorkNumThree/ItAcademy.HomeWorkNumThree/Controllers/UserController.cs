using System.Web.Mvc;
using ItAcademy.HomeWorkNumThree.Models;
using ItAcademy.HomeWorkNumThree.Halper;

namespace ItAcademy.HomeWorkNumThree.Controllers
{
    public class UserController : Controller
    {
        // GET: Users
        public ActionResult ShowAllUsers()
        {
            ViewBag.User = Helper.GetFromJson();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(User user)
        {
            ViewBag.User = user;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(object obj)
        {
            User user = (User)obj;
            Helper.AddToJson(user);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            int a = id;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList titlesList = new SelectList(System.Enum.GetNames(typeof(Title)), "Title");
            ViewBag.Title = titlesList;

            return View();
        }

        [HttpPost]
        public ActionResult Create(User a)
        {
            Helper.AddToJson(a);

            return View();
        }
    }
}