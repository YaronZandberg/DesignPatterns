using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    public class ShapeHolder : IProtoType<ShapeHolder>
    {
        public IList<Shape> Container { get; set; }

        public ShapeHolder ()
        {
            this.Container = new List<Shape>();
        }
        public void AddShape(Shape shapeToAdd)
        {
            Container.Add(shapeToAdd);
        }

        public void RemoveShape(Shape shapeToRemove)
        {
            Container.Remove(shapeToRemove);
        }

        public ShapeHolder clone()
        {
            // Making a new list which is a copy from the original
            ShapeHolder newContainer = new ShapeHolder();

            // Cloning every shape in the container of shapes
            foreach (Shape currShape in Container)
            {
                newContainer.AddShape(currShape.clone());
            }

            return newContainer;
        }

        public override string ToString()
        {
            string finalString = "Shape list: ";

            foreach (Shape currShape in Container)
            {
                finalString += currShape.ToString();
            }

            return finalString;
        }
    }
}
