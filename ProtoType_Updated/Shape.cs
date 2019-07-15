using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    public abstract class Shape : IProtoType<Shape>
    {
        public abstract Shape clone();
    }
}
