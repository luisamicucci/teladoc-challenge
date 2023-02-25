using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Teladoc.Application.Commands.AddNewUser;
using Teladoc.Application.Models;
using Teladoc.Application.Queries.RetrieveUsers;
using TeladocAPI.Controllers;

namespace Teladoc.Test.API
{
    public class UserControllerTests
    {
        private readonly UserController _controller;
        private readonly Mock<IMediator> _mediatorMock;
        private readonly UserModel _userModelMock = new UserModel
        {
            DateOfBirth = DateTime.Now.AddYears(-20),
            Email = "luis@gmail.com",
            FirstName = "Luis",
            LastName = "Amicucci"
        };

        public UserControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new UserController(_mediatorMock.Object);
        }

        [Fact]
        public async Task Post_ReturnsOkResult()
        {
            // Arrange
            _mediatorMock.Setup(m => m.Send(It.IsAny<AddNewUserCommand>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(true);

            // Act
            var result = await _controller.Post(_userModelMock);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal("User created", okResult.Value);
        }

        [Fact]
        public async Task Get_ReturnsOkResult()
        {
            // Arrange
            var response = new List<UserModel>
            {
                _userModelMock
            };

            _mediatorMock.Setup(m => m.Send(It.IsAny<RetrieveUsersQuery>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(response);

            // Act
            var result = await _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(response, okResult.Value);
        }
    }
}