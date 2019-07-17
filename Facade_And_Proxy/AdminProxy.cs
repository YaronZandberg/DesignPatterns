using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public AdminProxy()
        {
        }

        public void CreateCompany()
        {
            systemFacade.CreateCompany();
        }

        public void CreateCustomer()
        {
            systemFacade.CreateCustomer();
        }
    }
}
