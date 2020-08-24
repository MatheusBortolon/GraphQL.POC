namespace GraphQL.POC.Domain.Entitys
{
    public struct KeyValueEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValueEntity(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
