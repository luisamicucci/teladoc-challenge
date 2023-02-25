using AutoMapper;
using Teladoc.Application.Exceptions;
using Teladoc.Application.Interfaces;
using Teladoc.Domain.Entities;
using Teladoc.Infrastructure.Interfaces;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandHandler : ICommandHandler<AddNewUserCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public AddNewUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(AddNewUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request.User);

            if(!await _userRepository.IsEmailUnique(user.Email))
            {
                throw new BadRequestException($"Email value must be unique in our system. Email: {user.Email} already exists.");
            }

            return await _userRepository.Create(user);
        }
    }
}
