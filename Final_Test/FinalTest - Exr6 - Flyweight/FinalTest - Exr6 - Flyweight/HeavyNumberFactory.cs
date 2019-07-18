using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX6
{
    public static class HeavyNumberFactory
    {
        private static Dictionary<string, TooMuchHeavyNumber> veryMuchHeavyNumbers = new Dictionary<string, TooMuchHeavyNumber>();
        
        public static TooMuchHeavyNumber GetVeryHeavynumber(string key)
        {
            if (veryMuchHeavyNumbers.TryGetValue(key, out TooMuchHeavyNumber result))
            {
                return result;
            }
            else
            {
                string[] HeavyNum = key.Split(',');
                veryMuchHeavyNumbers.Add(key, new TooMuchHeavyNumber(Convert.ToInt32(HeavyNum[0]), Convert.ToInt32(HeavyNum[1])));
                return veryMuchHeavyNumbers[key];
            }
        }

    }
}
