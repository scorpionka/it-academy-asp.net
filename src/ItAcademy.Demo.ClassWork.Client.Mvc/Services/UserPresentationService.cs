using System.Collections.Generic;
using AutoMapper;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;
using ItAcademy.Demo.ClassWork.Domain.Services.Interfaces;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Services
{
    public class UserPresentationService : IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;

        public UserPresentationService(IUserDomainService userDomainService)
        {
            this.userDomainService = userDomainService;
        }

        public List<UserViewModel> GetByNameWithRole(string name)
        {
            var users = userDomainService.GetByNameWithRole(name);

            var usersViewModel = Mapper.Map<List<UserViewModel>>(users);

            return usersViewModel;
        }
    }
}