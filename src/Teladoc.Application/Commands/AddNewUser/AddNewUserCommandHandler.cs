using AutoMapper;
using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Teladoc.Domain.Entities;
using Teladoc.Infrastructure.Interfaces;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandHandler : IRequestHandler<AddNewUserCommand, bool>
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
            var validator = new AddNewUserCommandValidator();

            var results = validator.Validate(request);

            bool validationSucceeded = results.IsValid;

            if (!validationSucceeded)
            {
                var failures = results.Errors.ToList();
                var message = new StringBuilder();
                failures.ForEach(f => { message.Append(f.ErrorMessage + Environment.NewLine); });
                throw new ValidationException(message.ToString());
            }

            var user = _mapper.Map<User>(request.User);

            if(!await _userRepository.IsEmailUnique(user.Email))
            {
                throw new ValidationException("Email field must be unique");
            }

            return await _userRepository.Create(user);
        }
    }
}
