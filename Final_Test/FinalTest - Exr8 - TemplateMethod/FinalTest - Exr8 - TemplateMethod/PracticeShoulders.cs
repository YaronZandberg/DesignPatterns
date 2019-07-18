using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PracticeShoulders : PracticeTemplateBase
    {
        protected override void ExecuteWork()
        {
            Console.WriteLine("     Executing shoulder exercise ...");
        }
    }
}
