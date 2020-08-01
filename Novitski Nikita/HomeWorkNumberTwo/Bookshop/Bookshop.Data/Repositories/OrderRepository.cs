using Bookshop.Data.Context;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System.Collections.Generic;


namespace Bookshop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private IVirtualDb db;

        public OrderRepository(IVirtualDb context)
        {
            db = context;
        }

        public List<Order> GetAllOrders()
        {
            return db.GetOrders();
        }




    }
}
