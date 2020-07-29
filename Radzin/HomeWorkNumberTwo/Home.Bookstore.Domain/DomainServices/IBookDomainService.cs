using Home.Bookstore.Domain.Models;

namespace Home.Bookstore.Domain.DomainServices
{
    public interface IBookDomainService
    {
        Book[] GetFiveMostPopular();
        Book[] GetAll();
        Order[] GetAllOrder();
        Order[] GetAllOrderToday();
    }
}