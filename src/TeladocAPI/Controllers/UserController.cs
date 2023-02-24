using MediatR;
using Microsoft.AspNetCore.Mvc;
using Teladoc.Application.Commands.AddNewUser;
using Teladoc.Domain.Entities;
using TeladocAPI.Models;

namespace TeladocAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserModel model)
        {
            var user = new User();

            user += model;

            await _mediator.Send(new AddNewUserCommand() { User = user });
            return Ok("User created");
        }
    }
}
