using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX6
{
    public class TooMuchHeavyNumber
    {
        public int BaseNum;
        public int PowerNum;

        public int GetBaseNumber()
        {
            return (this.BaseNum);
        }

        public int GetPowerNumber()
        {
            return (this.PowerNum);
        }

        public TooMuchHeavyNumber(int baseNum, int powerNum)
        {
            this.BaseNum = baseNum;
            this.PowerNum = powerNum;
        }

        public double GetResult()
        {
            return Math.Pow(Convert.ToDouble(this.GetBaseNumber()), Convert.ToDouble(this.GetPowerNumber()));
        }
    }
}
