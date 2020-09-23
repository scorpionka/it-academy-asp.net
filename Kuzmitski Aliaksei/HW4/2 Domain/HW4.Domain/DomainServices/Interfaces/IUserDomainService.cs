using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
        User GetUser(int id);
        void DeleteUser(int userId);
        bool ValidationOfUserData(User user);
    }
}
