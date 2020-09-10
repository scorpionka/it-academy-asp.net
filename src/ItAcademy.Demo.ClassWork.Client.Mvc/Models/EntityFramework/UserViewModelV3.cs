using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using ItAcademy.Demo.ClassWork.Client.Mvc.Validators;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework
{
    [Validator(typeof(UserValidator))]
    public class UserViewModelV3
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string RoleName { get; set; }
    }
}