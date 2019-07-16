namespace Adapter
{
    public class ClientData
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public ClientData(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}