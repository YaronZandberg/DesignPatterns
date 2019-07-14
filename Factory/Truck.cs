using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Truck : Vehicle
    {
        protected string groundName;
        public Truck(string model, float cylinder, string color, int numberOfWheels, string groundName) : base(model, cylinder, color, numberOfWheels)
        {
            this.groundName = groundName;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {groundName}";
        }
    }
}
