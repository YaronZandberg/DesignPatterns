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
            ProxyFactory proxyFactory = new ProxyFactory();
            ClientProxy myCustomerProxy = proxyFactory.Login("Yaron", "Aa123456");
            Console.WriteLine("Customer's actions:");
            ((CustomerProxy)myCustomerProxy).BuyTicket();
            ((CustomerProxy)myCustomerProxy).ShowMyTickets();
            Console.WriteLine();

            ClientProxy myCompanyProxy = proxyFactory.Login("ELAL", "13579");
            Console.WriteLine("Company's actions:");
            ((CompanyProxy)myCompanyProxy).CreateFlight();
            ((CompanyProxy)myCompanyProxy).CancelFlight();
            Console.WriteLine();

            ClientProxy myAdminProxy = proxyFactory.Login("admin", "admin");
            Console.WriteLine("Admin's actions");
            ((AdminProxy)myAdminProxy).CreateCompany();
            ((AdminProxy)myAdminProxy).CreateCustomer();
            Console.WriteLine();

            //ClientProxy wrongProxy = proxyFactory.Login("admin", "555");
        }
    }
}
