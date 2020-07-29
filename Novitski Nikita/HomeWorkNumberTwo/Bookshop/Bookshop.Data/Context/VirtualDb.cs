using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;


namespace Bookshop.Data.Context
{
    public class VirtualDb : IVirtualDb
    {

        public List<Book> AllBooks { get; set; } = new List<Book>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public VirtualDb()
        {
            TableInitialization();
        }

        private void TableInitialization()
        {
            if (AllBooks.Count== 0)
            {
                CreateBooks();
                CreateOrders();
            }
        }


        public List<Book> GetBooks()
        {
            return AllBooks;
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        private void CreateBooks()
        {
            Book book1 = new Book() { Id = GetGuid(), Title = "Война и мир", Price = 112.3M, Availability = true };
            Book book2 = new Book() { Id = GetGuid(), Title = "Книга 1", Price = 112.3M, Availability = true };
            Book book3 = new Book() { Id = GetGuid(), Title = "Книга 2", Price = 1322.3M, Availability = true };
            Book book4 = new Book() { Id = GetGuid(), Title = "Книга 3", Price = 1232.3M, Availability = true };
            Book book5 = new Book() { Id = GetGuid(), Title = "Книга 4", Price = 11322.3M, Availability = true };
            Book book6 = new Book() { Id = GetGuid(), Title = "Книга 5", Price = 1122.3M, Availability = true };
            Book book7 = new Book() { Id = GetGuid(), Title = "Книга 6", Price = 1322.3M, Availability = true };
            Book book8 = new Book() { Id = GetGuid(), Title = "Книга 7", Price = 1322.3M, Availability = true };
            Book book9 = new Book() { Id = GetGuid(), Title = "Книга 8", Price = 1132.3M, Availability = true };
            AllBooks.AddRange(new List<Book> { book1, book2, book3, book4, book5, book6, book7, book8, book9 });
        }

        private void CreateOrders()
        {
            Order order1 = new Order() { Id = GetGuid(), CustomerName = "Novitski Nikita", Books = new List<Book> { AllBooks[1], AllBooks[2], AllBooks[3], AllBooks[4], AllBooks[6] }, CreatedAt = new DateTime(2001, 12, 02) };
            Order order2 = new Order() { Id = GetGuid(), CustomerName = "Petrov Egor", Books = new List<Book> { AllBooks[5], AllBooks[6], AllBooks[7], AllBooks[8], AllBooks[8], AllBooks[6] }, CreatedAt = DateTime.Now };
            Order order3 = new Order() { Id = GetGuid(), CustomerName = "Prochor Evgeny", Books = new List<Book> { AllBooks[0], AllBooks[1], AllBooks[2], AllBooks[3], AllBooks[4], AllBooks[5], AllBooks[6], AllBooks[6] }, CreatedAt = new DateTime(2019, 02, 12) };
            Order order4 = new Order() { Id = GetGuid(), CustomerName = "Vorotnitsky Dasha", Books = new List<Book> { AllBooks[1], AllBooks[1], AllBooks[2], AllBooks[2], AllBooks[3], AllBooks[4], AllBooks[6] }, CreatedAt = DateTime.Now };
            Orders.AddRange(new List<Order> { order1, order2, order3, order4 });
        }

        private Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        
    }
}
