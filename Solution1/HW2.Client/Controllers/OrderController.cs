using AutoMapper;
using HW2.Client.Models;
using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HW2.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderDomainService orderDomainService;

        public OrderController(IOrderDomainService orderDomainService)
        {
            this.orderDomainService = orderDomainService;
        }

        // GET: Order
        [HttpGet]
        public JsonResult AllOrders()
        {
            List<Order> order = orderDomainService.AllOrders();

            //var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, OrderView>());
            //var map = new Mapper(config);
            //var orderView = map.Map<List<Order>, OrderView>(order);

            //return Json(orderView, JsonRequestBehavior.AllowGet);
            return Json(order, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult TodayOrders()
        {
            List<Order> order = orderDomainService.TodayOrders();

            //var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, OrderView>());
            //var map = new Mapper(config);
            //var orderView = map.Map<List<Order>, OrderView>(order);

            //return Json(orderView, JsonRequestBehavior.AllowGet);
            return Json(order, JsonRequestBehavior.AllowGet);
        }
    }
}