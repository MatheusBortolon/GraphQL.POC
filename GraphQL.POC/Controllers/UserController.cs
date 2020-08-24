using GraphQL.POC.Domain.Contract;
using GraphQL.POC.Domain.Entitys;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GraphQL.POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserUseCase userUseCase;

        public UserController(IUserUseCase userUseCase)
        {
            this.userUseCase = userUseCase;
        }

        [HttpGet(nameof(GetUsers))]
        public IEnumerable<User> GetUsers() =>
            userUseCase.GetUsers();

        [HttpGet(nameof(GetUsersByDocument))]
        public IEnumerable<User> GetUsersByDocument(string document) =>
            userUseCase.GetUsersByDocument(document);

        [HttpGet(nameof(GetUsersByPartialName))]
        public IEnumerable<User> GetUsersByPartialName(string partialName) =>
            userUseCase.GetUsersByPartialName(partialName);
    }
}
