using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System.Collections.Generic;

namespace HW2.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public static readonly List<Book> books = new List<Book>()
        {
            new Book(){Id = 1, Title = "Jules Verne. 20,000 thousand leagues under the sea", Amount = 5},
            new Book(){Id = 2, Title = "Walter Scott. Ivanhoe.", Amount = 3},
            new Book(){Id = 3, Title = "Lev Tolstoy. War and Peace.", Amount = 8},
            new Book(){Id = 4, Title = "F. Scott Fitzgerald. The Great Gatsby.", Amount = 2},
            new Book(){Id = 5, Title = "Harper Lee. To Kill a Mockingbird.", Amount = 0},
            new Book(){Id = 6, Title = "J.K. Rowling. Harry Potter and the Sorcerer s Stone.", Amount = 1},
            new Book(){Id = 7, Title = "George Orwell. 1984.", Amount = 10},
            new Book(){Id = 8, Title = "J.D. Salinger. The Catcher in the Rye.", Amount = 2},
            new Book(){Id = 9, Title = "J.R.R. Tolkien. The Hobbit.", Amount = 5},
            new Book(){Id = 10, Title = "Ray Bradbury. Fahrenheit 451.", Amount = 3},
        };

        public List<Book> AllBooks()
        {
            return books;
        }

        public List<Book> TopFiveBooks()
        {
            List<Book> topFiveBooks = new List<Book>();
            topFiveBooks.Add(books[4]);
            topFiveBooks.Add(books[5]);
            topFiveBooks.Add(books[3]);
            topFiveBooks.Add(books[7]);
            topFiveBooks.Add(books[1]);
            return topFiveBooks;
        }
    }
}
