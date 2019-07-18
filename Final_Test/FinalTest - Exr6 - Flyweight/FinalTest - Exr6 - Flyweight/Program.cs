using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            TooMuchHeavyNumber firstHugeNumber = HeavyNumberFactory.GetVeryHeavynumber("9,12");
            Console.WriteLine(firstHugeNumber.GetResult());

            TooMuchHeavyNumber secondHugeNumber = HeavyNumberFactory.GetVeryHeavynumber("5,4");
            Console.WriteLine(secondHugeNumber.GetResult());

            TooMuchHeavyNumber thirdHugeNumber = HeavyNumberFactory.GetVeryHeavynumber("8,13");
            Console.WriteLine(thirdHugeNumber.GetResult());

            TooMuchHeavyNumber forthHugeNumber = HeavyNumberFactory.GetVeryHeavynumber("7,4");
            Console.WriteLine(forthHugeNumber.GetResult());
        }
    }
}
