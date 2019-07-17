using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HalfPriceTopping : ToppingDecoratorBase
    {
        public HalfPriceTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + ", and same Details, but half price";
        }

        public override double GetPrice()
        {
            return ((pizza.GetPrice()) * 0.5);
        }
    }
}
