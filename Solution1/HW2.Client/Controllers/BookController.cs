using AutoMapper;
using HW2.Client.Models;
using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW2.Client.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookDomainService bookDomainService;

        public BookController(IBookDomainService bookDomainService)
        {
            this.bookDomainService = bookDomainService;
        }
        // GET: Book
        public JsonResult AllOrders()
        {
            Book book = bookDomainService.AllOrders();

            //BookView bookView = Mapper.Map<Book, BookView>(book);

            throw new NotImplementedException();

            //return Json(bookView);
        }
    }
}