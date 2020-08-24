using GraphQL.POC.Domain.Entitys;
using System.Collections.Generic;

namespace GraphQL.POC.Domain.Contract
{
    public interface IUserUseCase
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByDocument(string document);
        IEnumerable<User> GetUsersByPartialName(string partialName);
    }
}