using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class FlightDAO
    {
       public void InsertTicket()
        {
            Console.WriteLine("Inserting ticket to the DB");
        }

        public void GetMyTickets()
        {
            Console.WriteLine("Getting all tickets from the DB");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Inserting flight to the DB");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Removing the flight from the DB");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Inserting company to the DB");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Inserting customer to the DB");
        }
    }
}
