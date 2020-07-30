using HW2.Domain.Models;
using System.Collections.Generic;

namespace HW2.Domain.Repositories
{
    public interface IBookRepository : IBaseRepository
    {
        List<Book> AllBooks();
        List<Book> TopFiveBooks();
    }
}
