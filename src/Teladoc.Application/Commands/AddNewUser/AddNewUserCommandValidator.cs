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
                .WithMessage("The FirstName field is required");
            RuleFor(x => x.User.LastName)
                .NotEmpty().WithMessage("The LastName field is required");
            RuleFor(x => x.User.Email)
                .NotEmpty()
                .WithMessage("The Email field is required")
                .EmailAddress()
                .WithMessage("A valid email is required");
            RuleFor(x => x.User.DateOfBirth)
                .NotEmpty()
                .WithMessage("The DateOfBirth field is required");
        }
    }
}
