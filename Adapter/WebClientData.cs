namespace Adapter
{
    public class WebClientData
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string Ip { get; set; }

        public bool Ssl { get; set; }

        public WebClientData(string name, string id, string ip, bool ssl)
        {
            this.Name = name;
            this.Id = id;
            this.Ip = ip;
            this.Ssl = ssl;
        }

        public ClientData GetClientData()
        {
            return (new ClientData(this.Name, this.Id));
        }
    }
}