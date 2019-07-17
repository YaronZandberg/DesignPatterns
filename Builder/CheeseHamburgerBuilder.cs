using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CheeseHamburgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Not Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("hamburger 300 gram");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Fat cheese");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 70 ILS");
        }
    }
}
