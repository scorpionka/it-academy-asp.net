using System;
using FluentValidation;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Validators
{
    public class UserValidator : AbstractValidator<UserViewModelV3>
    {
        public UserValidator(IUserPresentationService userPresentationService)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(10).WithMessage("First Name can have a max of 10 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Please specify a last name.")
                .MaximumLength(10).WithMessage("Last Name can have a max of 15 characters.")
                .Must(LastNameUnique);

            RuleFor(x => x)
                .Must(ValidateFirstAndLastNames)
                .WithMessage("Last Name and First Name in total can have a max of 10 characters.");
        }

        private bool LastNameUnique(UserViewModelV3 m, string lastName)
        {
            return true;
        }

        private bool ValidateFirstAndLastNames(UserViewModelV3 m)
        {
            return m.LastName?.Length + m.FirstName?.Length <= 10;
        }
    }
}
