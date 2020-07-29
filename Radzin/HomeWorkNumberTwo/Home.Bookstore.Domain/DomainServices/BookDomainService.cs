using AutoMapper;
using Home.Bookstore.Data.Models;
using Home.Bookstore.Data.Repositories;
using Home.Bookstore.Data.Repositories.Interfaces;
using Home.Bookstore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Bookstore.Domain.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;
        private readonly IOrderRepository orderRepository;

        public BookDomainService(IBookRepository bookRepository, IOrderRepository orderRepository)
        {
            this.bookRepository = bookRepository;
            this.orderRepository = orderRepository;
        }

        public Book[] GetFiveMostPopular()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<BookData, Book>());
            var mapper = new Mapper(configuration);
            BookData[] bookData = bookRepository.GetFiveMostPopular();
            Book[] FiveMostPopular = mapper.Map<BookData[], Book[]>(bookData);
            return FiveMostPopular;
        }

        public Book[] GetAll()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<BookData, Book>());
            var mapper = new Mapper(configuration);
            BookData[] bookData = bookRepository.GetAll();
            Book[] All = mapper.Map<BookData[], Book[]>(bookData);
            return All;
        }

        public Order[] GetAllOrder() 
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<OrderData, Order>());
            var mapper = new Mapper(configuration);
            OrderData[] orderData = orderRepository.GetAllOrder();
            Order[] All = mapper.Map<OrderData[], Order[]>(orderData);
            return All;
        }

        public Order[] GetAllOrderToday()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<OrderData, Order>());
            var mapper = new Mapper(configuration);
            OrderData[] orderData = orderRepository.GetAllOrderToday();
            Order[] allOrderToday = mapper.Map<OrderData[], Order[]>(orderData);
            return allOrderToday;
        }


    }
}
