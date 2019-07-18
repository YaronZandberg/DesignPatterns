using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShowStatusProxy myStatusCarProxy = new CarShowStatusProxy();
            Console.WriteLine("Proxy actions:");
            myStatusCarProxy.ShowFuel();
            myStatusCarProxy.ShowLocation();
        }
    }
}
