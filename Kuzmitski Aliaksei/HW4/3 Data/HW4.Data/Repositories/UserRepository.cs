using HW4.Domain.Models;
using HW4.Domain.Models.Other;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public List<User> GetAllUsers()
        {
            return GetSelectedInfo()
                .Include(x => x.Country)
                .Include(x => x.City)
                .ToList();
        }

        public User GetUser(int id)
        {
            var user = Get(id);
            unitOfWork.Entry(user).Reference(x => x.Country).Load();
            unitOfWork.Entry(user).Reference(x => x.City).Load();
            return user;
        }

        public bool UniquenessOfEmail(string email)
        {
            return !GetSelectedInfo().Any(x => x.Email.Equals(email));
        }

        public List<FullName> GetAllFullNames()
        {
            return GetSelectedInfo().Select(c => new FullName
            {
                FirstName = c.FirstName,
                LastName = c.LastName
            }).ToList();
        }

        public bool UniquenessOfPhone(string phone)
        {
            return !GetSelectedInfo().Any(x => x.Phone.Equals(phone));
        }
    }
}