using ItAcademy.Demo.ClassWork.Domain.Entities;
using ItAcademy.Demo.ClassWork.Domain.Repositories;
using ItAcademy.Demo.ClassWork.Domain.UnitOfWork;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
