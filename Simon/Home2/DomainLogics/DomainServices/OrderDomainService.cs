using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogics.DomainServices
{
    public class OrderDomainService : IOrderDomainService
    {
        public List<BookOrder> BookOrdersToday()
        {
            BookOrder order = new BookOrder()
            {
                Book = new Book { BookAuthor = "author", BookPrice = 1, BookTitle = "title" },
                TimeOrder = DateTime.Now
            };

            var orders = new List<BookOrder>();
            orders.Add(order);
            var allBookOrdersToday = orders.Where(x => x.TimeOrder.Day == DateTime.Today.Day).ToList();
            return allBookOrdersToday;
        }

        public List<BookOrder> AllBookOrder()
        {
            BookOrder order = new BookOrder()
            {
                Book = new Book { BookAuthor = "author", BookPrice = 1, BookTitle = "title" },
                TimeOrder = DateTime.Now
            };

            var allBookOrders = new List<BookOrder>();
            allBookOrders.Add(order);
            
            return allBookOrders;
        }
    }
}
