using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    public abstract class WindowDecoratorBase : IWindow
    {

        protected IWindow window;
        public abstract string GetDetails();

        public WindowDecoratorBase(IWindow window)
        {
            this.window = window;
        }

    }
}
