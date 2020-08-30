using HW3.Domain.Models;

namespace HW3.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository
    {
        void CreateUser(User user);
        User ReadUser(int id);
        void UpdateUser(User user);
        void DeleteUser(User user);
        Country ReadCountry(int id);
        City ReadCity(int id);
    }
}
