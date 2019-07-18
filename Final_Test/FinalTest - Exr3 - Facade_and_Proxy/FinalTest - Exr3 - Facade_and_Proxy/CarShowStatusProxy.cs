using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class CarShowStatusProxy : ICarShowStatus
    {
        protected CarSystemFacade systemFacade = new CarSystemFacade();

        public CarShowStatusProxy()
        {
        }

        public void ShowFuel()
        {
            systemFacade.ShowFuel();
        }

        public void ShowLocation()
        {
            systemFacade.ShowLocation();
        }
    }
}
