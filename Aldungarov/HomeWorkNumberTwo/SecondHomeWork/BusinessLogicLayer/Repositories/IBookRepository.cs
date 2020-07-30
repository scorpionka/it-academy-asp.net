using System.Collections.Generic;

namespace BusinessLogicLayer.Repositories
{
    public interface IBookRepository : IBaseRepository
    {
        Book GetBook();
        List<Book> GetAllBooks();
    }
}
