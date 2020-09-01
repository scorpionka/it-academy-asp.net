using System.Collections.Generic;
using ItAcademy.Demo.ClassWork.Domain.Entities;

namespace ItAcademy.Demo.ClassWork.Domain.Services.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetByNameWithRole(string name);
    }
}