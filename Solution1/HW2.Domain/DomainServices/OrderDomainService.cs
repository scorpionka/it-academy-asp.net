using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System.Collections.Generic;

namespace HW2.Domain.DomainServices
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IOrderRepository orderRepository;

        public OrderDomainService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> AllOrders()
        {
            List<Order> orderData = orderRepository.AllOrders();

            return orderData;
        }

        public List<Order> TodayOrders()
        {
            List<Order> orderData = orderRepository.TodayOrders();

            return orderData;
        }
    }
}
