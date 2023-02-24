using MediatR;
using Microsoft.AspNetCore.Mvc;
using Teladoc.Application.Commands.AddNewUser;
using Teladoc.Application.Models;
using Teladoc.Application.Queries.RetrieveUsers;

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
            await _mediator.Send(new AddNewUserCommand() { User = model });
            return Ok("User created");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _mediator.Send(new RetrieveUsersQuery());
            return Ok(users);
        }
    }
}
