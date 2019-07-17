using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class EntertainmentDevice
    {
        protected int Max;
        protected int State;
        protected bool IsOn;

        public EntertainmentDevice(int max, int state, bool isOn)
        {
            this.Max = max;
            this.State = state;
            this.IsOn = isOn;
        }

        public abstract void PrintState();

        public abstract void PressNext();

        public abstract void PressPrevious();

        public void TurnOn()
        {
            Console.WriteLine("Turnning on...");
            this.IsOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Turnning off...");
            this.IsOn = false;
        }
    }
}
