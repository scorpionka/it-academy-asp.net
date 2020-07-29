using Home.Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Bookstore.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public BookData[] GetAll()
        {
            var bookdata = new List<BookData>();
            for (int i=0; i<20 ; i++) 
            {
                bookdata.Add(new BookData { Name = "Book #" + (i + 1) });
            }
            BookData[] data = bookdata.ToArray();
            return data;
        }

        public OrderData[] GetAllOrder()
        {
            var orderdata = new List<OrderData>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                orderdata.Add(new OrderData { Id=i+1, Sum=200+1*(i+1),Date= new DateTime(2020, 7, rnd.Next(28, 30)),bookdata =new BookData { Name = "Book #" + (i + 1) } });
            }
            OrderData[] data = orderdata.ToArray();
            return data;
        }
    }
}
