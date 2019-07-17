using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public class StartNumber : IFormula
    {
        public double FirstNumber { get; set; }

        public StartNumber(double firstNumber)
        {
            this.FirstNumber = firstNumber;
        }

        public void ModifyNumber(double firstNumber)
        {
            this.FirstNumber = firstNumber;
        }

        public string GetFormula()
        {
            return this.FirstNumber.ToString();
        }

        public double GetResult()
        {
            return this.FirstNumber;
        }
    }
}
