using Home.Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Bookstore.Data.Repositories.Interfaces
{
    public interface IOrderRepository : IBaseRepository
    {
        OrderData[] GetAllOrderToday();
    }
}
