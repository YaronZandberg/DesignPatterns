using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TomatoTopping : ToppingDecoratorBase
    {
        public TomatoTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + ", and tomato";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() + 8;
        }
    }
}
