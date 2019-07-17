using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FactoryHamburger
    {
        public Hamburger CreateHamburger(string hamburgerName)
        {
            if (hamburgerName.Equals("VeggNormalHamburger"))
            {
                VeggHamburgerBuilder vhb = new VeggHamburgerBuilder();
                vhb.BuildHamburger();
                return vhb.GetHamburger();
            }
            else if (hamburgerName.Equals("VeggHamburgerWithLettuce"))
            {
                VeggHambBuilderLettuce vhl = new VeggHambBuilderLettuce();
                vhl.BuildHamburger();
                return vhl.GetHamburger();
            }
            else if (hamburgerName.Equals("CheeseNormalHamburger"))
            {
                CheeseHamburgerBuilder chb = new CheeseHamburgerBuilder();
                chb.BuildHamburger();
                return chb.GetHamburger();
            }
            else if (hamburgerName.Equals("CheeseHamburgerWithOnion"))
            {
                CheeseHambBuilderOnion cho = new CheeseHambBuilderOnion();
                cho.BuildHamburger();
                return cho.GetHamburger();
            }

            throw new ArgumentException($"cannot create hamburger from type {hamburgerName} !");
        }
    }
}