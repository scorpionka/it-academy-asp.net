using HW2.Domain.Models;
using System.Collections.Generic;

namespace HW2.Domain.Repositories
{
    public interface IOrderRepository : IBaseRepository
    {
        List<Order> AllOrders();
        List<Order> TodayOrders();
    }
}
