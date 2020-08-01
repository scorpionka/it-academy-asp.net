using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Repositories
{
    class OrderRepository : BaseRepository, IOrderRepository
    {
      public  List<BookOrder> AllBookOrder()
        {
            throw new NotImplementedException();
        }

      public List<BookOrder> BookOrdersToday()
        {
            throw new NotImplementedException();
        }
    }
}
