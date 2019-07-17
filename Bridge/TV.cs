using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : EntertainmentDevice
    {
        public TV(int max, int currentChannel, bool isOn) : base(max, currentChannel, isOn)
        {
        }

        public override void PrintState()
        {
            Console.WriteLine("Current channel: " + this.State);
        }

        public override void PressNext()
        {
            Console.WriteLine("Moving 1 channel forward");
            this.State = (this.State + 1 + Max) % Max;
            PrintState();
        }

        public override void PressPrevious()
        {
            Console.WriteLine("Moving 1 channel back");
            this.State = (this.State - 1 + Max) % Max;
            PrintState();
        }
    }
}
