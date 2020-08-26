using System.Collections.Generic;

namespace GraphQL.POC.Domain.Entitys
{
    public struct User
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public Address Home { get; set; }
        public Address Work { get; set; }
        public IEnumerable<Address> Favorites { get; set; }

        public User(string name, string document, Address home, Address work, IEnumerable<Address> favorites)
        {
            Name = name;
            Document = document;
            Home = home;
            Work = work;
            Favorites = favorites;
        }

    }
}
