using HW2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Domain.DomainServices.Interfaces
{
    public interface IBookDomainService
    {
        List<Book> AllBooks();
    }
}
