using System.Collections.Generic;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces
{
    public interface IUserPresentationService : IBasePresentationService
    {
        List<UserViewModel> GetByNameWithRole(string name);
    }
}