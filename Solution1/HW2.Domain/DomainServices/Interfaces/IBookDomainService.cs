using HW2.Domain.Models;
using System.Collections.Generic;

namespace HW2.Domain.DomainServices.Interfaces
{
    public interface IBookDomainService
    {
        List<Book> AllBooks();
        List<Book> TopFiveBooks();
    }
}
