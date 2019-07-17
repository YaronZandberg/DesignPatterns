using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNumber startNUmber = new StartNumber(5);
            IFormula startMulResult = new MulDecorator(startNUmber, 2);
            IFormula addAndStartMulResult = new AddDecorator(startMulResult, 100);
            IFormula divAndAddAndStartMulResult = new DivDecorator(addAndStartMulResult, 12);
            IFormula subAndDivAndaddAndStartMulResult = new SubDecorator(divAndAddAndStartMulResult, 3);
            IFormula mulAndSubAnddivAndaddAndStartMulResult = new MulDecorator(subAndDivAndaddAndStartMulResult, 4);
            IFormula addAndMulAndSubAnddivAndaddAndStartMulResult = new AddDecorator(mulAndSubAnddivAndaddAndStartMulResult, 7);

            Console.WriteLine(addAndMulAndSubAnddivAndaddAndStartMulResult.GetFormula());
            Console.WriteLine(addAndMulAndSubAnddivAndaddAndStartMulResult.GetResult());

            startNUmber.ModifyNumber(30);

            Console.WriteLine(addAndMulAndSubAnddivAndaddAndStartMulResult.GetFormula());
            Console.WriteLine(addAndMulAndSubAnddivAndaddAndStartMulResult.GetResult());        }
    }
}
