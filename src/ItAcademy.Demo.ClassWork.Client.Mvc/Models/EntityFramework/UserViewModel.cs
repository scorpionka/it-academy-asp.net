﻿using System.ComponentModel.DataAnnotations;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string RoleName { get; set; }
    }
}