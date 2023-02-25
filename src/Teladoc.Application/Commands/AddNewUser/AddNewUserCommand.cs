using Teladoc.Application.Interfaces;
using Teladoc.Application.Models;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommand : ICommand<bool>
    {
        public UserModel User { get; set; }
    }
}
