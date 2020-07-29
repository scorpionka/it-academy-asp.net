using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Domain.DomainServices.ProductDomainService
{
    public class GetAllBooksDomainService : IGetAllBooksDomainService
    {
        private readonly IProductRepository productRepository;
        public GetAllBooksDomainService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Book> GetAllBooks()
        {
            return productRepository.GetAllBooks();
        }
    }
}
