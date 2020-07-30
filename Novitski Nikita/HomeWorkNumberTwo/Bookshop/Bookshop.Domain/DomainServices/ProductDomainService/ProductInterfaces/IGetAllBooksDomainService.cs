using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces
{
    public interface IGetAllBooksDomainService
    {
        List<Book> GetAllBooks();
    }
}
