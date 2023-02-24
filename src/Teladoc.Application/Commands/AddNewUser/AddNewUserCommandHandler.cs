using MediatR;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandHandler : IRequestHandler<AddNewUserCommand, bool>
    {
        public Task<bool> Handle(AddNewUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
