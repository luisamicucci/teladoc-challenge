using AutoMapper;
using MediatR;
using Teladoc.Application.Models;

namespace Teladoc.Application.Queries.RetrieveUsers
{
    public class RetrieveUsersQueryHandler : IRequestHandler<RetrieveUsersQuery, List<UserModel>>
    {
        private readonly IMapper _mapper;

        public RetrieveUsersQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<List<UserModel>> Handle(RetrieveUsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
