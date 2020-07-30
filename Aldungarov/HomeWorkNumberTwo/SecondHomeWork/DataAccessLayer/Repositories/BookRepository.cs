using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Repositories;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public Book GetBook()
        {
            Book book = new Book() { Name = "Some book", Rate = 5 };

            return book;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> bookList = new List<Book>();
            for (int i = 1; i <= 10; i++)
            {
                Book someBook = new Book();
                someBook.Name = "Some Book Name №" + i;
                
                if (i == 5 || i == 7)
                {
                    someBook.Rate = 3;
                }
                else if (i == 1 || i == 3)
                {
                    someBook.Rate = 5;
                }
                else
                {
                    someBook.Rate = 1;
                }

                bookList.Add(someBook);
            }

            return bookList;
        }
    }
}
