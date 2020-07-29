using AutoMapper;
using Home.Bookstore.Client.Models;
using Home.Bookstore.Domain.DomainServices;
using Home.Bookstore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Bookstore.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

 
    }
}