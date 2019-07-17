using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public CustomerProxy()
        {
        }

        public void BuyTicket()
        {
            systemFacade.BuyTicket();
        }

        public void ShowMyTickets()
        {
            systemFacade.ShowMyTickets();
        }
    }
}
