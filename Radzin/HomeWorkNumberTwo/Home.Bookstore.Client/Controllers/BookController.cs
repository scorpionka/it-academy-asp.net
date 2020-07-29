using AutoMapper;
using Home.Bookstore.Client.Models;
using Home.Bookstore.Data.Repositories.Interfaces;
using Home.Bookstore.Domain.DomainServices;
using Home.Bookstore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Home.Bookstore.Client.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookDomainService bookDomainService;
        
        public BookController(IBookDomainService bookDomainService) 
        {
            this.bookDomainService=bookDomainService;
        }
        public JsonResult GetFiveMostPopular()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Book,BookView >());
            var mapper = new Mapper(configuration);
            Book[] bookData = bookDomainService.GetFiveMostPopular();
            BookView[] bookView = mapper.Map<Book[], BookView[]>(bookData);


            return Json(bookView, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookView>());
            var mapper = new Mapper(configuration);
            Book[] bookData = bookDomainService.GetAll();
            BookView[] bookView = mapper.Map<Book[], BookView[]>(bookData);
            return Json(bookView, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetAllOrder()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderView>());
            var mapper = new Mapper(configuration);
            Order[] orderData = bookDomainService.GetAllOrder();
            OrderView[] orderView = mapper.Map<Order[], OrderView[]>(orderData);
            return Json(orderView, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllOrderToday()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderView>());
            var mapper = new Mapper(configuration);
            Order[] orderData = bookDomainService.GetAllOrderToday();
            OrderView[] orderView = mapper.Map<Order[], OrderView[]>(orderData);
            return Json(orderView, JsonRequestBehavior.AllowGet);
        }
    }
}