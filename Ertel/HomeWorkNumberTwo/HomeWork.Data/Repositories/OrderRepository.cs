using HomeWork.Data.Entities;
using HomeWork.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Repositories
{
    public class OrderRepository: IOrder<Order>
    {
        public IEnumerable<Order> TodayOrders()
        {

            List<Order> orders = new List<Order>();
            for (int i = 0; i < 5; i++)
            {
                List<OrderItem> orderItem = new List<OrderItem>();
                for (int j = 0; j < i+1; j++)
                {
                    orderItem.Add(new OrderItem { Id = j, Book = new Book { Id = j, Name = $"book {j}", Price = j * 100 }, Quantity = j + 1 });
                }
                orders.Add(new Order { Id = i, Name = $"order {i}", OrderItems = orderItem, Address = $"Test st. №{i}" });
            }
            return orders;
        }


        // private readonly DatabaseContext db;
        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            List<Order> orders = new List<Order>();
            for (int i = 0; i < 50; i++)
            {
                List<OrderItem> orderItem = new List<OrderItem>();
                for (int j = 0; j < i + 1; j++)
                {
                    orderItem.Add(new OrderItem { Id = j, Book = new Book { Id = j, Name = $"book {j}", Price = j * 100 }, Quantity = j + 1 });
                }
                orders.Add(new Order { Id = i, Name = $"order {i}", OrderItems = orderItem, Address = $"Test st. №{i}" });
            }
            return orders;
        }
    }
}
