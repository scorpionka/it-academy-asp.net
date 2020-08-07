using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using BusinessLogicLayer.Repositories;

namespace BusinessLogicLayer.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;

        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book GetBook()
        {
            Book bookData = bookRepository.GetBook();

            return bookData;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> bookList = bookRepository.GetAllBooks();

            return bookList;
        }

        public List<Book> GetTopFiveBooks()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Book>, Book>());
            var mapper = new Mapper(configuration);
            List<Book> topFiveBooksList = new List<Book>();
            List<Book> bookList = bookRepository.GetAllBooks();
            
            var topFiveBooks = bookList.OrderByDescending(q => q.Rate).Take(5);
            topFiveBooksList = mapper.Map<IEnumerable<Book>, List<Book>>(topFiveBooks);

            return topFiveBooksList;
        }
    }
}
