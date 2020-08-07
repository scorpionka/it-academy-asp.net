using System.Collections.Generic;

namespace BusinessLogicLayer.DomainServices
{
    public interface IBookDomainService
    {
        Book GetBook();
        List<Book> GetAllBooks();
        List<Book> GetTopFiveBooks();
    }
}
