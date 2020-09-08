using FluentValidation;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Validators
{
    public class UserValidator : AbstractValidator<UserViewModelV3>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(10).WithMessage("First Name can have a max of 10 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Please specify a last name. V")
                .MaximumLength(10).WithMessage("Last Name can have a max of 15 characters.");
        }
    }
}
