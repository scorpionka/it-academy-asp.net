﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Areas.Product.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: Product/Home
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}