using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        protected EntertainmentDevice Device;

        public RemoteControl(EntertainmentDevice device)
        {
            this.Device = device;
        }

        public EntertainmentDevice GetDevice()
        {
            return this.Device;
        }

        public void SetDevice(EntertainmentDevice device)
        {
            this.Device = device;
        }

        public void PrintState()
        {
            GetDevice().PrintState();
        }

        public void TurnOn()
        {
            GetDevice().TurnOn();
        }

        public void TurnOff()
        {
            GetDevice().TurnOff();
        }

        public void PressNext()
        {
            GetDevice().PressNext();
        }

        public void PressPrevious()
        {
            GetDevice().PressPrevious();
        }
    }
}
