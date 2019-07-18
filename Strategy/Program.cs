using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection myCollection = new NumberCollection();
            for (int i = 1; i <= 12; i++)
            {
                myCollection.AddNumber(i);
                myCollection.Sort(myCollection.GetNumbers());
            }

            for (int i = 12; i >= 7; i--)
            {
                myCollection.RemoveNumber(i);
                myCollection.Sort(myCollection.GetNumbers());
            }
        }
    }
}
