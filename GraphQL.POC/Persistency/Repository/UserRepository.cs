using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Persistency.Contracts;
using AutoFixture;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.POC.Persistency.Repository
{
    public class UserRepository : IUserRepository
    {
        private IEnumerable<User> Users;

        public UserRepository()
        {
            var fixture = new Fixture();
            Users = fixture.CreateMany<User>(10);
        }

        public IEnumerable<User> GetUsers() =>
            Users;

        public IEnumerable<User> GetUsersByDocument(string document) =>
            Users.Where(x => x.Document == document);

        public IEnumerable<User> GetUsersByPartialName(string partialName) =>
            Users.Where(x => x.Name.Contains(partialName));
    }
}
