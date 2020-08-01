using BusinessLogicLayer.Models;
using System.Collections.Generic;


namespace BusinessLogicLayer.Repositories
{
    public interface IOrderRepository : IBaseRepository
    {
        Order GetOrder();
        List<Order> GetAllOrders();
        List<Order> GetTodayOrders();
    }
}
