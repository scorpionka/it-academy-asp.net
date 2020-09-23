using HW4.Client.Models.ViewModels;
using HW4.Client.PresentationServices.Interfaces;
using HW4.Client.Util.Mapper;
using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;

namespace HW4.Client.PresentationServices
{
    public class UserPresentationService : Mapper, IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly ICityDomainService cityDomainService;
        private readonly IUnitOfWork unitOfWork;

        public UserPresentationService(IUserDomainService userDomainService, ICountryDomainService countryDomainService,
            ICityDomainService cityDomainService, IUnitOfWork unitOfWork)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;
            this.cityDomainService = cityDomainService;
            this.unitOfWork = unitOfWork;
        }

        public void AddUser(CreateUserViewModel user)
        {
            User newUser = CreateUserViewModelMapping(user);
            newUser.City = cityDomainService.GetCity(user.CityId);
            newUser.Country = countryDomainService.GetCountry(user.CountryId);
            userDomainService.AddUser(newUser);
        }

        public List<AllUsersViewModel> AllUsers()
        {
            List<User> allUsers = userDomainService.GetAllUsers();
            List<AllUsersViewModel> allUsersView = new List<AllUsersViewModel>();

            foreach (var x in allUsers)
            {
                allUsersView.Add(AllUsersViewModelMapping(x));
            }
            return allUsersView;
        }

        public EditUserViewModel GetEditUserView(int id)
        {
            User user = userDomainService.GetUser(id);
            return EditUserViewModelMapping(user);
        }

        public void EditUser(EditUserViewModel user)
        {
            User updateUser = EditUserViewModelMappingToUser(user);
            updateUser.City = cityDomainService.GetCity(user.CityId);
            updateUser.Country = countryDomainService.GetCountry(user.CountryId);
            unitOfWork.SaveChanges();
        }

        public DeleteUserViewModel GetDeleteUserView(int id)
        {
            User user = userDomainService.GetUser(id);
            return DeleteUserViewModelMapping(user);
        }

        public void DeleteUser(int userId)
        {
            userDomainService.DeleteUser(userId);
        }

        public List<Country> AllCountries()
        {
            return countryDomainService.GetAllCountries();
        }

        public List<City> AllCities()
        {
            return cityDomainService.GetAllCities();
        }
    }
}