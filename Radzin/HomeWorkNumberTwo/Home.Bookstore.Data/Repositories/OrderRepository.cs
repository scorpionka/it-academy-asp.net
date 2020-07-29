using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home.Bookstore.Data.Models;
using Home.Bookstore.Data.Repositories.Interfaces;

namespace Home.Bookstore.Data.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderData[] GetAllOrderToday()
        {
            OrderData[] data = GetAllOrder();
            OrderData [] allOrderToday = data.Where(d => d.Date >= DateTime.Today).ToArray();
            return allOrderToday;
        }
    }
}
