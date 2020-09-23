using HW4.Client.Models.ViewModels;
using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Client.PresentationServices.Interfaces
{
    public interface IUserPresentationService
    {
        void AddUser(CreateUserViewModel user);
        List<AllUsersViewModel> AllUsers();
        EditUserViewModel GetEditUserView(int id);
        void EditUser(EditUserViewModel user);
        DeleteUserViewModel GetDeleteUserView(int id);
        void DeleteUser(int userId);
        List<Country> AllCountries();
        List<City> AllCities();
    }
}
