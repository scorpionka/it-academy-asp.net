using HW4.Client.Models.ViewModels;
using HW4.Domain.Models;

namespace HW4.Client.Util.Mapper
{
    public class Mapper
    {
        public User CreateUserViewModelMapping(CreateUserViewModel user)
        {
            return new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Title = user.Title,
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments,
            };
        }

        public AllUsersViewModel AllUsersViewModelMapping(User user)
        {
            return new AllUsersViewModel
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}",
                Title = user.Title,
                Country = user.Country,
                City = user.City,
                Phone = user.Phone,
                Email = user.Email
            };
        }

        public EditUserViewModel EditUserViewModelMapping(User user)
        {
            return new EditUserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Title = user.Title,
                CountryId = user.Country.Id,
                CityId = user.City.Id,
                Comments = user.Comments,
            };
        }

        public User EditUserViewModelMappingToUser(EditUserViewModel user)
        {
            return new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Title = user.Title,
                Comments = user.Comments,
            };
        }

        public DeleteUserViewModel DeleteUserViewModelMapping(User user)
        {
            return new DeleteUserViewModel
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}",
            };
        }
    }
}