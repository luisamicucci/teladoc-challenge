using FluentValidation;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandValidator : AbstractValidator<AddNewUserCommand>
    {
        public AddNewUserCommandValidator()
        {
            RuleFor(x => x.User.DateOfBirth)
                .Must(dateOfBirth => dateOfBirth.AddYears(18) <= DateTime.Now)
                .WithMessage("You must be at least 18 years old");
            RuleFor(x => x.User.FirstName)
                .NotEmpty()
                .WithMessage("FirstName field is required");
            RuleFor(x => x.User.LastName)
                .NotEmpty().WithMessage("LastName field is required");
            RuleFor(x => x.User.Email)
                .NotEmpty()
                .WithMessage("Email field is required")
                .EmailAddress()
                .WithMessage("A valid email is required");
            RuleFor(x => x.User.DateOfBirth)
                .NotEmpty()
                .WithMessage("DateOfBirth field is required");
        }
    }
}
