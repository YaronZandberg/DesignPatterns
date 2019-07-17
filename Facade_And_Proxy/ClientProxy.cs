using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public abstract class ClientProxy
    {
        protected FlightSystemFacade systemFacade = new FlightSystemFacade();
    }
}
