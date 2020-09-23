using HW4.Domain.Models;
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

        private bool UniquenessOfEmail(string email)
        {
            return !GetSelectedInfo().Any(x => x.Email.Equals(email));
        }

        private bool UniquenessOfFullName(string fullName)
        {
            List<string> usersFullNames = new List<string>();
            GetFullNames()
                .ForEach(x => usersFullNames.Add($"{x.FirstName}+{x.LastName}"));
            return !usersFullNames.Contains(fullName);
        }

        private bool UniquenessOfPhone(string phone)
        {
            return !GetSelectedInfo().Any(x => x.Phone.Equals(phone));
        }

        private List<User> GetFullNames()
        {
            return GetSelectedInfo().Select(x => new User
            {
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
        }

        public bool ValidationOfUserData(User user)
        {
            return (!UniquenessOfFullName($"{user.FirstName}+{user.LastName}") & !UniquenessOfPhone(user.Phone) & !UniquenessOfEmail(user.Email));
        }
    }
}
