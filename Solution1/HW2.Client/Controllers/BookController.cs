using AutoMapper;
using AutoMapper.Configuration.Conventions;
using HW2.Client.Models;
using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        [HttpGet]
        public JsonResult AllBooks()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Book>, BookView>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(c => c)));
            List<Book> book = bookDomainService.AllBooks();
            var map = new Mapper(config);
            var bookView = map.Map<List<Book>, BookView>(book);
            return Json(bookView, JsonRequestBehavior.AllowGet);
            //return Json(book, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult TopFiveBooks()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Book>, BookView>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(c => c)));
            List<Book> book = bookDomainService.TopFiveBooks();
            var map = new Mapper(config);
            var bookView = map.Map<List<Book>, BookView>(book);
            return Json(bookView, JsonRequestBehavior.AllowGet);
            //return Json(book, JsonRequestBehavior.AllowGet);
        }

    }
}