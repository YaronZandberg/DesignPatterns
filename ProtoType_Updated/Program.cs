using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Updated
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(new Point(5, 5), 50.5);
            Rectangle rectangle = new Rectangle(new Point(0, 5), new Point(5, 5), new Point(0, 0), new Point(5, 0));

            //Console.WriteLine(circle);
            //Console.WriteLine(rectangle);

            ShapeHolder shapeholder = new ShapeHolder();
            shapeholder.AddShape(circle);
            shapeholder.AddShape(rectangle);

            Console.WriteLine(shapeholder);
            Console.WriteLine("============================================");

            DoStuffWithCircle(shapeholder.clone());

            Console.WriteLine(shapeholder);
        }

        public static void DoStuffWithCircle(ShapeHolder clonedShapeHolder)
        {
            Rectangle newRectangle = new Rectangle(new Point(0, 6), new Point(6, 6), new Point(0, 0), new Point(6, 0));
            Circle newCircle = new Circle(new Point(7, 7), 12.34);
            clonedShapeHolder.AddShape(newRectangle);
            clonedShapeHolder.AddShape(newCircle);
            Console.WriteLine(clonedShapeHolder);
            Console.WriteLine("=============================================");
        }
    }
}
