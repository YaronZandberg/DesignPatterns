using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            EntertainmentDevice myTV = new TV(100, 3, true);
            EntertainmentDevice myMemir = new Memir(50, 15, true);
            RemoteControl control = new RemoteControl(myTV);

            control.PrintState();
            control.TurnOff();
            control.TurnOn();
            control.PressNext();
            control.PressPrevious();
            control.SetDevice(myMemir);
            control.PrintState();
            control.TurnOff();
            control.TurnOn();
            control.PressNext();
            control.PressPrevious();

        }
    }
}
