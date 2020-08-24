using GraphQL.POC.Domain.Contract;
using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Persistency.Contracts;
using System.Collections.Generic;

namespace GraphQL.POC.Domain.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers() =>
            userRepository.GetUsers();

        public IEnumerable<User> GetUsersByDocument(string document) =>
            userRepository.GetUsersByDocument(document);

        public IEnumerable<User> GetUsersByPartialName(string partialName) =>
            userRepository.GetUsersByPartialName(partialName);

    }
}
