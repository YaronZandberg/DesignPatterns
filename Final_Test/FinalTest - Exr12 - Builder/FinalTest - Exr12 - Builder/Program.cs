using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory myFactory = new ComputerFactory();
            Console.WriteLine("Game: " + myFactory.ProduceComputer("Games"));
            Console.WriteLine("Work: " + myFactory.ProduceComputer("Work"));
            Console.WriteLine("Living room: " + myFactory.ProduceComputer("LivingRoom"));
        }
    }
}
