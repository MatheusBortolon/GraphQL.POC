namespace GraphQL.POC.Domain.Entitys
{
    public struct Address
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public KeyValueEntity Country { get; set; }

        public Address(string name, string street, int number, KeyValueEntity country)
        {
            Name = name;
            Street = street;
            Number = number;
            Country = country;
        }
    }
}
