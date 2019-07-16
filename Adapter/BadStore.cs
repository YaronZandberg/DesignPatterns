using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBWebData
    {
        public void Store(WebClientData webClientData)
        {
            Console.WriteLine($"Name: {webClientData.Name} ID: {webClientData.Id} IP: {webClientData.Ip} SSL: {webClientData.Ssl}");
        }
    }
}
