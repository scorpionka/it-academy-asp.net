using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookData ShowAllOrders()
        {
            throw new NotImplementedException();
        }

        public BookData ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookData ShowAllOrdersFromToday()
        {
            throw new NotImplementedException();
        }

        public BookData Show5MostPopular()
        {
            throw new NotImplementedException();
        }
    }
}
//все заказы
//все книги
//заказы сделанные сегодня
//топ 5 популярных книг