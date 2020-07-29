using Home.Bookstore.Data.Models;

namespace Home.Bookstore.Data.Repositories
{
    public interface IBookRepository : IBaseRepository
    {
        BookData[] GetFiveMostPopular();
    }
}