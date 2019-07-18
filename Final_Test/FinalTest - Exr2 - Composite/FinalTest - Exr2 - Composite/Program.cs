using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite(2);
            Component leftChild = new Leaf(4);
            Component rightChild = new Composite(6);
            Component leftChildOfRightChild = new Leaf(5);
            Component rightChildOfRightChild = new Leaf(8);
            rightChild.AddChild(leftChildOfRightChild);
            rightChild.AddChild(rightChildOfRightChild);
            root.AddChild(leftChild);
            root.AddChild(rightChild);
            root.Draw("");
            Console.WriteLine(root.Sum());
            Console.WriteLine("Does all tree is even? " + root.IsEven());
        }

        static bool IsEven(Component biNonde)
        {
            return biNonde.IsEven();
        }
    }
}
