using HW3.Domain.DomainServices.Interfaces;
using HW3.Domain.Repositories;

namespace HW3.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;
        public UserDomainService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
