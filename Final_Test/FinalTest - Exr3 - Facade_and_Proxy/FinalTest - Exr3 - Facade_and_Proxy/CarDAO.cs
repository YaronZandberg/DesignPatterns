using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class CarDAO
    {
       public void StartDriving()
        {
            Console.WriteLine("Strting drive... ");
        }

        public void EndDriving()
        {
            Console.WriteLine("Ending drive... ");
        }

        public void IncreaseSpeedOfCar()
        {
            Console.WriteLine("Increaasing the car's speed... ");
        }

        public void DecreaseSpeedOfCar()
        {
            Console.WriteLine("Decreaasing the car's speed... ");
        }

        public void TurningRight()
        {
            Console.WriteLine("Turning right the car... ");
        }

        public void TurningLeft()
        {
            Console.WriteLine("Turning left the car... ");
        }

        public void ShowStateOfFuel()
        {
            Console.WriteLine("Showing the fuel's state... ");
        }

        public void ShowMyLocation()
        {
            Console.WriteLine("Showing current location... ");
        }
    }
}
