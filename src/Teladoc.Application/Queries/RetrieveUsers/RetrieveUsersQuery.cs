using MediatR;
using Teladoc.Application.Models;

namespace Teladoc.Application.Queries.RetrieveUsers
{
    public class RetrieveUsersQuery : IRequest<List<UserModel>>
    {
    }
}
