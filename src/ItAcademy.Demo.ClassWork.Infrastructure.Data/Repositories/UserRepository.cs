using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ItAcademy.Demo.ClassWork.Domain.Entities;
using ItAcademy.Demo.ClassWork.Domain.Repositories;
using ItAcademy.Demo.ClassWork.Domain.UnitOfWork;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<User> GetByNameWithRole(string name)
        {
            return GetItems()
                .Include(x=>x.Role)
                .Where(x => x.FirstName.Equals(name))
                .ToList();
        }
    }
}
