using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSort : ISort
    {
        public void Sort(List<int> numbers)
        {
            Console.WriteLine("Sorting numbers with QUICK_SORT");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
