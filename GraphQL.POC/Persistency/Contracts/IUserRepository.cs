using GraphQL.POC.Domain.Entitys;
using System.Linq;

namespace GraphQL.POC.Persistency.Contracts
{
    public interface IUserRepository
    {
        IQueryable<User> GetUsers();
        IQueryable<User> GetUsersByDocument(string document);
        IQueryable<User> GetUsersByPartialName(string partialName);
    }
}