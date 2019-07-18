using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making chest practice:");
            PracticeTemplateBase chestPractice = new PracticeChest();
            chestPractice.Run();
            Console.WriteLine();

            Console.WriteLine("Making legs practice:");
            PracticeTemplateBase legsPractice = new PracticeLegs();
            legsPractice.Run();
            Console.WriteLine();

            Console.WriteLine("Making shoulders practice:");
            PracticeTemplateBase shouldersPractice = new PracticeShoulders();
            shouldersPractice.Run();
            Console.WriteLine();
        }
    }
}
