using HomaWork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Bll.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderModel> GetAll();
        IEnumerable<OrderModel> TodayOrders();
    }
}
