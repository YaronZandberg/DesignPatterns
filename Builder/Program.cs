using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            //menu.Add(new VeggHamburgerBuilder());
            //menu.Add(new VeggHambBuilderLettuce());

            //Hamburger hamb = PrepareHamburger(menu[0]);

            Dictionary<string, Hamburger> menu = new Dictionary<string, Hamburger>();
            FactoryHamburger hamburgerFactory = new FactoryHamburger();

            Hamburger veggNormalHam = hamburgerFactory.CreateHamburger("VeggNormalHamburger");
            menu.Add("Normal Veggeterian Hamberger", veggNormalHam);
            Hamburger vegglHamWithLettuce = hamburgerFactory.CreateHamburger("VeggHamburgerWithLettuce");
            menu.Add("Veggeterian with lettuce", vegglHamWithLettuce);
            Hamburger cheeseNormalHam = hamburgerFactory.CreateHamburger("CheeseNormalHamburger");
            menu.Add("Normal Cheese hamburger", cheeseNormalHam);
            Hamburger cheeseHamWithLettuce = hamburgerFactory.CreateHamburger("CheeseHamburgerWithOnion");
            menu.Add("Cheese hamburger with onion", cheeseHamWithLettuce);

            foreach (KeyValuePair<string, Hamburger> currPairNameAndHamburger in menu)
            {
                Console.WriteLine(currPairNameAndHamburger.Key + ": ");
                Console.WriteLine(currPairNameAndHamburger.Value);
            }
        }

        //static Hamburger PrepareHamburger(HamburgerBuilder builder)
        //{
        //    builder.BuildHamburger();
        //    return builder.GetHamburger();
        //}
    }
}
