using HomeWork.Data.Entities;
using HomeWork.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Repositories
{
    public class BookRepository : IBook<Book>
    {
        public IEnumerable<Book> TopFive()
        {

            List<Book> books = new List<Book>();
            for (int i = 0; i < 5; i++)
            {
                books.Add(new Book { Id = i, Name = $"book {i}", Price = i * 100 });
            }
            return books;
        }

        // private readonly DatabaseContext db;
        IEnumerable<Book> IRepository<Book>.GetAll()
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < 15; i++)
            {
                books.Add(new Book { Id = i, Name = $"book {i}", Price = i*100 });
            }
            return books;
        }
    }
}
