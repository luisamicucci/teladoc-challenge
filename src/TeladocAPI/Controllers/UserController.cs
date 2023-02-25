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
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(UserModel model)
        {
            await _mediator.Send(new AddNewUserCommand() { User = model });
            return Ok("User created");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var users = await _mediator.Send(new RetrieveUsersQuery());
            return Ok(users);
        }
    }
}
