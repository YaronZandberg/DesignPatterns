using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    public class Point : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Point : (X = {X} , Y = {Y})";
        }

        public override Shape clone()
        {
            return new Point(this.X, this.Y);
        }
    }
}