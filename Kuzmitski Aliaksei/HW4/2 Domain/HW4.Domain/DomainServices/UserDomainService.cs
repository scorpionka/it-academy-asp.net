﻿using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices
{
    public class UserDomainService : BaseDomainService, IUserDomainService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserDomainService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
            unitOfWork.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            userRepository.DeleteById(userId);
            unitOfWork.SaveChanges();
        }

        public void EditUser()
        {
            unitOfWork.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public User GetUser(int id)
        {
            return userRepository.GetUser(id);
        }

        public bool ValidationOfUserData(User user)
        {
            return userRepository.ValidationOfUserData(user);
        }
    }
}
