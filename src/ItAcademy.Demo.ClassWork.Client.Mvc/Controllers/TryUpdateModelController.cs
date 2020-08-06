using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.TryUpdateModel;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public class TryUpdateModelController : Controller
    {
        // GET: TryUpdateModel
        public ActionResult IndexV1(PersonViewModel personViewModel, StudentViewModel studentViewModel)
        {
            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IndexV2()
        {
            var personViewModel = new PersonViewModel();
            personViewModel.Age = Convert.ToInt32(Request.QueryString["Age"]);
            personViewModel.Name = Request.QueryString["Name"];

            var studentViewModel = new StudentViewModel();
            studentViewModel.DataFromDB = "IndexV2";
            studentViewModel.University = Request.QueryString["University"];
            studentViewModel.Name = Request.QueryString["Name"];

            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IndexV3()
        {
            var personViewModel = new PersonViewModel();
            var studentViewModel = new StudentViewModel();
            studentViewModel.DataFromDB = "IndexV3";

            TryUpdateModel(personViewModel);
            TryUpdateModel(studentViewModel);

            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IndexInclude([Bind(Include = "University, Name")] StudentViewModel studentViewModel)
        {
            return Json(studentViewModel, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IndexExclude([Bind(Exclude = "University, Name")] StudentViewModel studentViewModel)
        {
            return Json(studentViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}