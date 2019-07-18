using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    public class ColorFrameDecorator : WindowDecoratorBase
    {
        public ColorFrameDecorator(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + ", colorful window frame";
        }
    }
}
