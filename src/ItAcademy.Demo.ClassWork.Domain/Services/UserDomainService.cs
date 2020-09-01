using System.Collections.Generic;
using ItAcademy.Demo.ClassWork.Domain.Entities;
using ItAcademy.Demo.ClassWork.Domain.Repositories;
using ItAcademy.Demo.ClassWork.Domain.Services.Interfaces;

namespace ItAcademy.Demo.ClassWork.Domain.Services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;

        public UserDomainService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetByNameWithRole(string name)
        {
            //// persorm some additional domain logic here

            return userRepository.GetByNameWithRole(name);
        }
    }
}