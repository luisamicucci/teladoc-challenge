using FluentValidation;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandValidator : AbstractValidator<AddNewUserCommand>
    {
        public AddNewUserCommandValidator()
        {
            RuleFor(x => x.User.FirstName).NotEmpty().WithMessage("The FirstName is required");
            RuleFor(x => x.User.LastName).NotEmpty().WithMessage("The LastName is required");
            RuleFor(x => x.User.Email).NotEmpty().WithMessage("The email is required").EmailAddress().WithMessage("A valid email is required");
            RuleFor(x => x.User.DateOfBirth).NotEmpty().WithMessage("The DateOfBirth is required");
        }
    }
}
