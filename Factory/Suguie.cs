using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Suguie : Vehicle
    {
        protected string company;
        public Suguie(string model, float cylinder, string color, int numberOfWheels, string company) : base(model, cylinder, color, numberOfWheels)
        {
            this.company = company;
        }

        public override string ToString()
        {
            return "Suguei " + base.ToString() + $" {company}";
        }
    }
}
