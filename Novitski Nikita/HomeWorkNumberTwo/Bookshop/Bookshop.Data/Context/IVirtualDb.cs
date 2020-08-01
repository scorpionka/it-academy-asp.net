using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Data.Context
{
    public interface IVirtualDb
    {
        List<Book> GetBooks();
        List<Order> GetOrders();

    }
}
