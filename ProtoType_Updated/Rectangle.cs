using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    public class Rectangle : Shape
    {
        public Point PointLeftUp { get; set; }
        public Point PointRightUp { get; set; }
        public Point PointLeftDown { get; set; }
        public Point PointRightDown { get; set; }

        public Rectangle(Point pointLeftUp, Point pointRightUp, Point pointLeftDown, Point pointRightDown)
        {
            this.PointLeftUp = pointLeftUp;
            this.PointRightUp = pointRightUp;
            this.PointLeftDown = pointLeftDown;
            this.PointRightDown = pointRightDown;
        }

        public override string ToString()
        {
            return $"Rectangle PointLeftUp = {PointLeftUp} PointRightUp = {PointRightUp} PointLeftDown = {PointLeftDown} PointRightDown = {PointRightDown}";
        }

        public override Shape clone()
        {
            return new Rectangle((Point)PointLeftUp.clone(), (Point)PointRightUp.clone(), (Point)PointLeftDown.clone(), (Point)PointRightDown.clone());
        }
    }
}
