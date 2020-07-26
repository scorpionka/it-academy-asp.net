using HomeWork.Bll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Pl.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public JsonResult GetAll()
        {
            var allOrders =orderService.GetAll();
            return Json(allOrders, JsonRequestBehavior.AllowGet);
        }
        public JsonResult TodayOrders()
        {
            var todayOrders = orderService.TodayOrders();
            return Json(todayOrders, JsonRequestBehavior.AllowGet);
        }
    }
}