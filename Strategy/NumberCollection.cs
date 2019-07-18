using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NumberCollection
    {
        protected const int LIMIT_NUMBERS = 10;
        protected List<int> numbersList = new List<int>();
        protected ISort Sorter;
        public NumberCollection()
        {
            this.Sorter = new MergeSort();
        }

        public List<int> GetNumbers()
        {
            return this.numbersList;
        }

        public void Sort(List<int> numbers)
        {
            this.Sorter.Sort(numbers);
        }

        public void AddNumber(int number)
        {
            numbersList.Add(number);
            
            // Check if there are more than 1000 numbers
            // If there are, changing the sorter to quick sort
            if (numbersList.Count > LIMIT_NUMBERS)
            {
                this.Sorter = new QuickSort();
            }
        }

        public void RemoveNumber(int number)
        {
            numbersList.Remove(number);

            // Check if there are less than 1000 numbers
            // If there are, changing the sorter to merge sort
            if (numbersList.Count <= LIMIT_NUMBERS)
            {
                this.Sorter = new MergeSort();
            }
        }
    }
}