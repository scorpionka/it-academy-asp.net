using AutoMapper;
using Bookshop.Client.Models.Orders.Queries;
using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bookshop.Client.Controllers
{
    public class OrderController : Controller  
    {
        private readonly IGetAllOrdersDomainService ordersDomainService;
        private readonly IGetOrdersMadeTodayDomainService getOrdersMadeTodayDS;
        

        public OrderController(IGetAllOrdersDomainService getAllOrdersDomain, IGetOrdersMadeTodayDomainService getOrdersMadeTodayDS)
        {
            ordersDomainService = getAllOrdersDomain;
            this.getOrdersMadeTodayDS = getOrdersMadeTodayDS;
        }
        [HttpGet]
        public ActionResult GetAllOrders()
        {
            List<Order> orders = ordersDomainService.GetAllOrders();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, GetAllOrdersVm>()  // used for mapping example
                    .ForMember(dest => dest.Orders, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);
            var ordersVm = mapper.Map<List<Order>, GetAllOrdersVm>(orders);

            return Json(ordersVm, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetOrdersMadeToday()
        {
            List<Order> orders = getOrdersMadeTodayDS.GetOrdersMadeToday();
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, GetOrdersMadeTodayVm>()  // used for mapping example
                    .ForMember(dest => dest.Orders, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);
            var ordersVm = mapper.Map<List<Order>, GetOrdersMadeTodayVm>(orders);

            return Json(ordersVm, JsonRequestBehavior.AllowGet);
        }
    }
}