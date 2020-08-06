using System.Collections.Generic;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.DomainServices
{
    public interface IOrderDomainService
    {
        Order GetOrder();
        List<Order> GetAllOrders();
        List<Order> GetTodayOrders();
    }
}
