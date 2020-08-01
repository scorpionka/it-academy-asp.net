using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace HW2.Data.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public static readonly List<Book> booksOrderAlex = new List<Book>
        {
            new Book(){Id = 1, Title = "Jules Verne. 20,000 thousand leagues under the sea", Amount = 4},
            new Book(){Id = 7, Title = "George Orwell. 1984.", Amount = 1},
            new Book(){Id = 9, Title = "J.R.R. Tolkien. The Hobbit.", Amount = 1},
        };

        public static readonly List<Book> booksOrderIvan = new List<Book>
        {
            new Book(){Id = 1, Title = "F. Scott Fitzgerald. The Great Gatsby.", Amount = 1},
            new Book(){Id = 7, Title = "George Orwell. 1984.", Amount = 2},
            new Book(){Id = 9, Title = "Ray Bradbury. Fahrenheit 451.", Amount = 1},
        };

        public static readonly List<Book> booksOrderPetr = new List<Book>
        {
            new Book(){Id = 1, Title = "Jules Verne. 20,000 thousand leagues under the sea", Amount = 1},
            new Book(){Id = 7, Title = "J.D. Salinger. The Catcher in the Rye.", Amount = 1},
            new Book(){Id = 9, Title = "Harper Lee. To Kill a Mockingbird.", Amount = 3},
        };

        public static readonly List<Order> order = new List<Order>()
        {
            new Order(){Id = 1, Name = "Alex", BooksOrder = booksOrderAlex, DayTime = new DateTime(2020, 7, 15)},
            new Order(){Id = 2, Name = "Ivan", BooksOrder = booksOrderIvan, DayTime = new DateTime(2020, 7, 30)},
            new Order(){Id = 3, Name = "Petr", BooksOrder = booksOrderPetr, DayTime = new DateTime(2020, 6, 29)},
        };

        public List<Order> AllOrders()
        {
            return order;
        }

        public List<Order> TodayOrders()
        {
            List<Order> todayOrders = new List<Order>();
            foreach (var x in order)
            {
                if (x.DayTime.Equals(DateTime.Today))
                {
                    todayOrders.Add(x);
                }
            }
            return todayOrders;
        }
    }
}
