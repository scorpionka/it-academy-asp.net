
using HomeWork.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Interfaces
{
    public interface IUnitOfWork 
    {
        IOrder<Order> Orders { get; }

        IBook<Book> Books { get; }

    }
}
