using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookshop.Domain.DomainServices.ProductDomainService
{
    public class GetTopFiveBooksDomainService : IGetTopFiveBooksDomainService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        public GetTopFiveBooksDomainService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }
        
        private Dictionary<Guid, int> numberBooksOrdered = new Dictionary<Guid, int>();

        public List<Book> GetTopFiveBooks()
        {
            CountAllOrderBooks();
          
            return GetBooks(GetFivePairsPopularBooks());
        }

        private IEnumerable<KeyValuePair<Guid,int>> GetFivePairsPopularBooks()
        {
            var list = numberBooksOrdered.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            return list.Take(5);
        }

        private void CountAllOrderBooks()
        {
            foreach (var order in orderRepository.GetAllOrders())
            {
                foreach (var book in order.Books)
                {
                    AddBooksOrdered(book.Id);
                }
            }
        }
        private void AddBooksOrdered(Guid BookId)
        {
            if (numberBooksOrdered.ContainsKey(BookId))
            {
                numberBooksOrdered[BookId] += 1;
            }
            else
            {
                numberBooksOrdered.Add(BookId, 1);
            }
        }

        private List<Book> GetBooks(IEnumerable<KeyValuePair<Guid, int>> valuePair)
        {
            List<Book> books = new List<Book>();
            foreach (var book in valuePair)
            {
                books.Add(productRepository.GetAllBooks().Find(b => b.Id == book.Key));
            }

            return books;
        }

       

        




    }
}
