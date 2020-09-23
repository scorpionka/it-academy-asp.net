using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;

namespace HW4.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
