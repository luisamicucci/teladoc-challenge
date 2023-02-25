using AutoMapper;
using Teladoc.Application.Interfaces;
using Teladoc.Application.Models;
using Teladoc.Infrastructure.Interfaces;

namespace Teladoc.Application.Queries.RetrieveUsers
{
    public class RetrieveUsersQueryHandler : IQueryHandler<RetrieveUsersQuery, List<UserModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public RetrieveUsersQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserModel>> Handle(RetrieveUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.RetrieveAll();

            return _mapper.Map<List<UserModel>>(users);
        }
    }
}
