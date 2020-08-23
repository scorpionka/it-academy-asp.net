﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public class ModelBinderExampleController : Controller
    {
        // val -> 123.4
        // val -> 123,4
        // val -> 123dot4
        public ActionResult Index(decimal val)
        {
            return Json(val, JsonRequestBehavior.AllowGet);
        }
    }
}