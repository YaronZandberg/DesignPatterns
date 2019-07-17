using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MashroomTopping : ToppingDecoratorBase
    {
        public MashroomTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + ", and mashrooms";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() + 3.5;
        }
    }
}
