using Home.Bookstore.Data.Models;
using System;
using System.Linq;

namespace Home.Bookstore.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookData[] GetFiveMostPopular()
        {
            BookData[] data = GetAll();
            BookData[] fiveMostPopular = data.Take(5).ToArray();
            return fiveMostPopular;
        }
    }
}
