using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public static readonly List<Book> books = new List<Book>()
        {
            new Book(){Id = 1, Title = "Jules Verne. 20,000 thousand leagues under the sea", Amount = 5},
            new Book(){Id = 2, Title = "Walter Scott. Ivanhoe.", Amount = 3},
            new Book(){Id = 3, Title = "Lev Tolstoy. War and Peace.", Amount = 8},
        };
        public List<Book> AllBooks()
        {
            return books;
        }
    }
}
