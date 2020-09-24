using HW4.Domain.Models;
using HW4.Domain.Models.Other;
using System.Collections.Generic;

namespace HW4.Domain.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetAllUsers();
        User GetUser(int id);
        bool UniquenessOfPhone(string phone);
        bool UniquenessOfEmail(string email);
        List<FullName> GetAllFullNames();
    }
}
