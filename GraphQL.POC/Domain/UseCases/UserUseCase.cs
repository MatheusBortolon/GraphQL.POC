using GraphQL.POC.Domain.Contract;
using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Persistency.Contracts;
using System.Linq;

namespace GraphQL.POC.Domain.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IQueryable<User> GetUsers() =>
            userRepository.GetUsers();

        public IQueryable<User> GetUsersByDocument(string document) =>
            userRepository.GetUsersByDocument(document);

        public IQueryable<User> GetUsersByPartialName(string partialName) =>
            userRepository.GetUsersByPartialName(partialName);

    }
}
