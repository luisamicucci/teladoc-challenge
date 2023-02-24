using AutoMapper;
using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teladoc.Application.Commands.AddNewUser
{
    public class AddNewUserCommandHandler : IRequestHandler<AddNewUserCommand, bool>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AddNewUserCommandHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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

            return true;
        }
    }
}
