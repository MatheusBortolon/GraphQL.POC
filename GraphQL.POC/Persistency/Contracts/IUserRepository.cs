using GraphQL.POC.Domain.Entitys;
using System.Collections.Generic;

namespace GraphQL.POC.Persistency.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByDocument(string document);
        IEnumerable<User> GetUsersByPartialName(string partialName);
    }
}