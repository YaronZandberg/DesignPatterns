using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("The lightswitch is off...");
            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            return this;
        }

        public ILightState TurnOn()
        {
            return this;
        }
    }
}
