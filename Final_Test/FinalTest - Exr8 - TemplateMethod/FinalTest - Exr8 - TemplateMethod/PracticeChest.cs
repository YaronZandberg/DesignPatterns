using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PracticeChest : PracticeTemplateBase
    {
        protected override void ExecuteWork()
        {
            Console.WriteLine("     Executing chest exercise ...");
        }
    }
}
