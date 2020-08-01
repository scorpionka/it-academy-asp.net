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
    public class GetAllOrdersDomainService : IGetAllOrdersDomainService
    {
        private readonly IOrderRepository orderRepository;
        public GetAllOrdersDomainService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
    }
}
