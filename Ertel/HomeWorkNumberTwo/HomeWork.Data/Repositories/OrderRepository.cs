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
                List<Book> books = new List<Book>();
                for (int j = 0; j < i+1; j++)
                {
                    books.Add(new Book { Id = j, Name = $"book {j}", Price = j * 100 });
                }

                orders.Add(new Order { Id = i, Name = $"book {i}", Books = books, Address = $"Test st. №{i}"});
            }
            return orders;
        }


        // private readonly DatabaseContext db;
        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            List<Order> orders = new List<Order>();
            for (int i = 0; i < 50 ; i++)
            {
                List<Book> books = new List<Book>();
                for (int j = 0; j < i + 1; j++)
                {
                    books.Add(new Book { Id = j, Name = $"book {j}", Price = j * 100 });
                }

                orders.Add(new Order { Id = i, Name = $"book {i}", Books = books, Address = $"Test st. №{i}" });
            }
            return orders;
        }
    }
}
