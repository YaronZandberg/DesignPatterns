using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Memir : EntertainmentDevice
    {
        public Memir(int max, int state, bool isOn) : base(max, state, isOn)
        {
        }

        public override void PrintState()
        {
            Console.WriteLine("Current show: " + this.State);
        }

        public override void PressNext()
        {
            Console.WriteLine("Moving 1 show forward");
            this.State = (this.State + 1 + Max) % Max;
            PrintState();
        }

        public override void PressPrevious()
        {
            Console.WriteLine("Moving 1 show back");
            this.State = (this.State - 1 + Max) % Max;
            PrintState();
        }
    }
}
