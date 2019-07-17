using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class FlightSystemFacade : ICustomer, ICompany, IAdmin
    {
        FlightDAO myFlightDAO = new FlightDAO();

        public void BuyTicket()
        {
            myFlightDAO.InsertTicket();
        }

        public void ShowMyTickets()
        {
            myFlightDAO.GetMyTickets();
        }

        public void CreateFlight()
        {
            myFlightDAO.InsertFlight();
        }

        public void CancelFlight()
        {
            myFlightDAO.RemoveFlight();
        }

        public void CreateCompany()
        {
            myFlightDAO.InsertCompany();
        }

        public void CreateCustomer()
        {
            myFlightDAO.InsertCustomer();
        }
    }
}
