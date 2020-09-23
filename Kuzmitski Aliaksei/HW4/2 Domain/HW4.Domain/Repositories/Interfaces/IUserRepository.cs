using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetAllUsers();
        User GetUser(int id);
        bool ValidationOfUserData(User user);
    }
}
