using AutoFixture;
using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Persistency.Contracts;
using System.Linq;

namespace GraphQL.POC.Persistency.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IQueryable<User> Users;

        public UserRepository()
        {
            var fixture = new Fixture();
            Users = fixture.CreateMany<User>(10)
                .AsQueryable();
        }

        public IQueryable<User> GetUsers() =>
            Users;

        public IQueryable<User> GetUsersByDocument(string document) =>
            Users.Where(x => x.Document == document);

        public IQueryable<User> GetUsersByPartialName(string partialName) =>
            Users.Where(x => x.Name.Contains(partialName));
    }
}
