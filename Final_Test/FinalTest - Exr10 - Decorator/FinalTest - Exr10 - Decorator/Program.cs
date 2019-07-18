using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow window = new BaseWindow();

            IWindow windowWith3D = new ThreeDLightDecorator(window);
            IWindow windowWith3DAndColorFrame = new ColorFrameDecorator(windowWith3D);
            IWindow windowWith3DAndColorFrameAndPartReflection = new PartReflectionDecorator(windowWith3DAndColorFrame);
            IWindow windowWith3DAndColorFrameAndPartReflectionAndShadow = new ShadowDecorator(windowWith3DAndColorFrameAndPartReflection);
            IWindow windowWith3DAndColorFrameAndPartReflectionAndShadowAndFlickerBackground = new FlickerBackDecorator(windowWith3DAndColorFrameAndPartReflectionAndShadow);

            Console.WriteLine(windowWith3DAndColorFrameAndPartReflectionAndShadowAndFlickerBackground.GetDetails());

        }
    }
}
