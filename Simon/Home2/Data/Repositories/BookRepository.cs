using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    class BookRepository :BaseRepository, IBookRepository
    {
        public List<Book> AllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetMostPopular()
        {
            throw new NotImplementedException();
        }
    }
}
