using HomeWork.Data.Entities;
using HomeWork.Data.Interfaces;
using HomeWork.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        //private DatabaseContext db;
        private BookRepository bookRepository;
        private OrderRepository orderRepository;

        public UnitOfWork(string connectionString)
        {
            // db = new DatabaseContext(connectionString);
        }
        public IOrder<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository();
                }
                return orderRepository;
            }
        }

        public IBook<Book> Books
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BookRepository();
                }
                return bookRepository;
            }
        }

    }
}
