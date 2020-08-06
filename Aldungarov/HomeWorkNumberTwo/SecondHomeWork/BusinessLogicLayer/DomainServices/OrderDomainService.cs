using System.Collections.Generic;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Repositories;

namespace BusinessLogicLayer.DomainServices
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IOrderRepository orderRepository;
        
        public OrderDomainService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order GetOrder()
        {
            Order orderData = orderRepository.GetOrder();

            return orderData;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> ordersList = orderRepository.GetAllOrders();

            return ordersList;
        }

        public List<Order> GetTodayOrders()
        {
            List<Order> ordersList = orderRepository.GetTodayOrders();

            return ordersList;
        }
    }
}
