﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    public class Circle : Shape
    {
        public Point Center { get; set; }

        public double Area { get; set;  }

        public Circle(Point center, double area)
        {
            this.Center = center;
            this.Area = area;
        }

        public override string ToString()
        {
            return $"Circle center {Center} area = {Area}";
        }

        public override Shape clone()
        {
            return new Circle((Point)Center.clone(), Area);
        }
    }
}
