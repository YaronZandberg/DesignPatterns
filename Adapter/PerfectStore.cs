using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void Store(ClientData clientData)
        {
            Console.WriteLine($"Name: {clientData.Name}");
            Console.WriteLine($"ID: {clientData.Id}");
        }
    }
}
