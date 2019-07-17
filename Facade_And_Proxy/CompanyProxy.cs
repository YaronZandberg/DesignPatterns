using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class CompanyProxy : ClientProxy, ICompany
    {
        public CompanyProxy()
        {
        }

        public void CreateFlight()
        {
            systemFacade.CreateFlight();
        }

        public void CancelFlight()
        {
            systemFacade.CancelFlight();
        }
    }
}
