using MediatR;
using Teladoc.Application.Models;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommand : IRequest<bool>
    {
        public UserModel User { get; set; }
    }
}
