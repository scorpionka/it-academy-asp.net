using Home.Bookstore.Data.Models;

namespace Home.Bookstore.Data.Repositories
{
    public interface IBaseRepository
    {
        BookData[] GetAll();
        OrderData[] GetAllOrder();

    }
}