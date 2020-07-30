using Bookshop.Data.Context;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System.Collections.Generic;


namespace Bookshop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IVirtualDb db;
        public ProductRepository(IVirtualDb context)
        {
            db = context;
        }
        
        public List<Book> GetAllBooks()
        {
            return db.GetBooks();   //////// ???????????????????
        }

        
    }
}
