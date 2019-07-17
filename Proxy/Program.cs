using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            RealATM atm = new RealATM();
            GetProxy(new ATMProxy());
            Console.WriteLine();

            atm.InsertCard();
            atm.EjectCard();
            Console.WriteLine("Current amount of money: ");
            Console.WriteLine(atm.GetTotalCash());
            Console.WriteLine("Despositing 1000. Current amount of money: ");
            atm.Desposit(1000);
            Console.WriteLine(atm.GetTotalCash());
            Console.WriteLine("Withdrawing 20000. Current amount of money: ");
            atm.Withdraw(20000);
            Console.WriteLine(atm.GetTotalCash());
        }

        static void GetProxy(IMonitorService proxy)
        {
            Console.WriteLine(proxy.GetStatus());
            Console.WriteLine(proxy.GetTotalCash());
        }
    }
}
