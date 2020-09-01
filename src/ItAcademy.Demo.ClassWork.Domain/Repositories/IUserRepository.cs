using System.Collections.Generic;
using ItAcademy.Demo.ClassWork.Domain.Entities;

namespace ItAcademy.Demo.ClassWork.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetByNameWithRole(string name);
    }
}
