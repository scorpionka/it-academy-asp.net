using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Domain.DomainServices.OrderDomainService
{
    public class GetOrdersMadeTodayDomainService : IGetOrdersMadeTodayDomainService
    {
        private readonly IOrderRepository orderRepository;
        public GetOrdersMadeTodayDomainService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        List<Order> ordersMadeToday = new List<Order>();
        public List<Order> GetOrdersMadeToday()
        {
            List<Order> orders = orderRepository.GetAllOrders();

            WriteOrderMadeToday(orders);

            return ordersMadeToday;
        }

        private void WriteOrderMadeToday(List<Order> orders)
        {
            orders.ForEach(order => {
                if (order.CreatedAt.ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                {
                    ordersMadeToday.Add(order);
                }
            });
        }
    }
}
