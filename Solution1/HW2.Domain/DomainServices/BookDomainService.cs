using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System.Collections.Generic;

namespace HW2.Domain.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;

        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> AllBooks()
        {
            List<Book> bookData = bookRepository.AllBooks();

            return bookData;
        }

        public List<Book> TopFiveBooks()
        {
            List<Book> bookData = bookRepository.TopFiveBooks();

            return bookData;
        }
    }
}
