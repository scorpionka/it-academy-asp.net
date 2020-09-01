using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItAcademy.Demo.ClassWork.Domain.Entities;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.Context;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.Repositories;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.UnitOfWork;

namespace ItAcademy.Demo.ClassWork.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CoreDbContext())
            {
                var uow = new UnitOfWork(db);
                var userRepository = new UserRepository(uow);
                //var user = new User
                //{
                //    FirstName = "Kate",
                //    LastName = "SomeLastName",
                //    Role = new Role
                //    {
                //        Name = "Admin"
                //    }
                //};

                //userRepository.Create(user);
                //uow.SaveChanges();


                List<User> users = userRepository.GetByNameWithRole("Kate");
                foreach (var dbUser in users)
                {
                    System.Console.WriteLine($"{dbUser.FirstName} {dbUser.LastName} {dbUser.Role.Name}");
                }
            }
        }
    }
}
