using MediatR;
using Teladoc.Domain.Entities;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommand : IRequest<bool>
    {
        public User User { get; set; }
    }
}
