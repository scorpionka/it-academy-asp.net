﻿using FluentValidation;
using HW4.Client.Models.ViewModels;
using HW4.Domain.DomainServices.Interfaces;

namespace HW4.Client.Validators
{
    public class EditUserViewModelValidator : AbstractValidator<EditUserViewModel>
    {
        public EditUserViewModelValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Please specify a First Name.")
                .MaximumLength(20).WithMessage("First Name can have a maximum of 20 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Please specify a Last Name.")
                .MaximumLength(30).WithMessage("Last Name can have a maximum of 30 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please specify a Phone Number.")
                .MaximumLength(15).WithMessage("Phone Number can have a maximum of 15 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please specify a Email.")
                .MaximumLength(30).WithMessage("Email can have a maximum of 30 characters.");

            RuleFor(x => x.UserTitle).
                NotNull().WithMessage("Please fill Title field.");

            RuleFor(x => x.Comments).
                MaximumLength(300).WithMessage("Field Comments can have a maximum of 300 characters.");
        }
    }
}