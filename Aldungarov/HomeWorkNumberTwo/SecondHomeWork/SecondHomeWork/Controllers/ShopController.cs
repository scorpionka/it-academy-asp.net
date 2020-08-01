using System.Web.Mvc;
using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.DomainServices;

namespace SecondHomeWork.Controllers
{
    public class ShopController : Controller
    {
        private readonly IOrderDomainService orderDomainService;
        private readonly IBookDomainService bookDomainService;

        public ShopController(IOrderDomainService orderDomainService, IBookDomainService bookDomainService)
        {
            this.orderDomainService = orderDomainService;
            this.bookDomainService = bookDomainService;
        }

        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetOrder()
        {
            Order order = orderDomainService.GetOrder();

            return Json(order, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllOrders()
        {
            List<Order> orders = orderDomainService.GetAllOrders();

            return Json(orders, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTodayOrders()
        {
            List<Order> orders = orderDomainService.GetTodayOrders();

            return Json(orders, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetBook()
        {
            Book book = bookDomainService.GetBook();

            return Json(book, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllBooks()
        {
            List<Book> books = bookDomainService.GetAllBooks();

            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTopFiveBooks()
        {
            List<Book> books = bookDomainService.GetTopFiveBooks();

            return Json(books, JsonRequestBehavior.AllowGet);
        }

    }
}