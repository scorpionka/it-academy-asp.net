using HW3.Domain.Models;
using HW3.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository()
        {
            countries = new List<Country>()
            {
                new Country(){Id = new Guid(), Name = "Belarus"},
                new Country(){Id = new Guid(), Name = "Russia"},
                new Country(){Id = new Guid(), Name = "Ukraine"},
                new Country(){Id = new Guid(), Name = "Poland"},
                new Country(){Id = new Guid(), Name = "Lituania"},
                new Country(){Id = new Guid(), Name = "Latvia"},
                new Country(){Id = new Guid(), Name = "USA"},
                new Country(){Id = new Guid(), Name = "Germany"},
                new Country(){Id = new Guid(), Name = "China"},
                new Country(){Id = new Guid(), Name = "France"},
                new Country(){Id = new Guid(), Name = "Great Britain"},
            };

            cities = new List<City>()
            {
                new City(){Id = new Guid(), Name = "Minsk"},
                new City(){Id = new Guid(), Name = "Gomel"},
                new City(){Id = new Guid(), Name = "Vitebsk"},
                new City(){Id = new Guid(), Name = "Mogilev"},
                new City(){Id = new Guid(), Name = "Grodno"},
                new City(){Id = new Guid(), Name = "Brest"},
                new City(){Id = new Guid(), Name = "Moscow"},
                new City(){Id = new Guid(), Name = "Saint Petersburg"},
                new City(){Id = new Guid(), Name = "Novosibirsk"},
                new City(){Id = new Guid(), Name = "Kiev"},
                new City(){Id = new Guid(), Name = "Kharkiv"},
                new City(){Id = new Guid(), Name = "Odessa"},
                new City(){Id = new Guid(), Name = "Warsaw"},
                new City(){Id = new Guid(), Name = "Krakow"},
                new City(){Id = new Guid(), Name = "Lodz"},
                new City(){Id = new Guid(), Name = "Vilnius"},
                new City(){Id = new Guid(), Name = "Riga"},
                new City(){Id = new Guid(), Name = "NY"},
                new City(){Id = new Guid(), Name = "Los Angeles"},
                new City(){Id = new Guid(), Name = "Chicago"},
                new City(){Id = new Guid(), Name = "Berlin"},
                new City(){Id = new Guid(), Name = "Hamburg"},
                new City(){Id = new Guid(), Name = "Munich"},
                new City(){Id = new Guid(), Name = "Chongqing"},
                new City(){Id = new Guid(), Name = "Shanghai"},
                new City(){Id = new Guid(), Name = "Beijing"},
                new City(){Id = new Guid(), Name = "Paris"},
                new City(){Id = new Guid(), Name = "Marseilles"},
                new City(){Id = new Guid(), Name = "Lyons"},
                new City(){Id = new Guid(), Name = "London"},
                new City(){Id = new Guid(), Name = "Birmingham"},
                new City(){Id = new Guid(), Name = "Leeds"},
            };

            users = new List<User>();

        }

        private List<User> users;
        private List<Country> countries;
        private List<City> cities;

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public User ReadUser(Guid id)
        {
            return users.Find(x => x.Id.Equals(id));
        }

        public void UpdateUser(User user)
        {
            users[users.FindIndex(x => x.Id.Equals(user.Id))] = user;
        }

        public void DeleteUser(Guid id)
        {
            users.RemoveAt(users.FindIndex(x => x.Id.Equals(id)));
        }

        public List<User> AllUsers()
        {
            return users;
        }


        public Country ReadCountry(Guid id)
        {
            return countries.Find(x => x.Id.Equals(id));
        }

        public List<Country> AllCountries()
        {
            return countries;
        }


        public City ReadCity(Guid id)
        {
            return cities.Find(x => x.Id.Equals(id));
        }

        public List<City> AllCities()
        {
            return cities;
        }
    }
}
