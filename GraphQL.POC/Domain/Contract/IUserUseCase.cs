using GraphQL.POC.Domain.Entitys;
using System.Linq;

namespace GraphQL.POC.Domain.Contract
{
    public interface IUserUseCase
    {
        IQueryable<User> GetUsers();
        IQueryable<User> GetUsersByDocument(string document);
        IQueryable<User> GetUsersByPartialName(string partialName);
    }
}