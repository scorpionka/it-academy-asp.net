using HomeWork.Bll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Pl.Controllers
{
    public class BookController : Controller
    {

        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public JsonResult GetAll()
        {
            var allBooks = bookService.GetAll();
            return Json(allBooks, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTopFive()
        {
            var topFive = bookService.GetTopFive();
            return Json(topFive, JsonRequestBehavior.AllowGet);
        }
    }
}