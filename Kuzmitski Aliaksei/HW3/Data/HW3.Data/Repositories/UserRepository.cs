using HW3.Domain.Models;
using HW3.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HW3.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private List<User> users;
        private List<Country> countries;
        private List<City> cities;

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public City ReadCity(int id)
        {
            return cities.FirstOrDefault(x => x.Id == id);
        }

        public Country ReadCountry(int id)
        {
            return countries.FirstOrDefault(x => x.Id == id);
        }

        public User ReadUser(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateUser(User user)
        {
            users[users.FindIndex(x => x.Id == user.Id)] = user;
        }

    }
}
