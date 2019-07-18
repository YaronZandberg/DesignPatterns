using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest___Exr5___State
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase Next;
        public abstract void Handle(string log, int level);

        public void SetNext(LogHandlerBase nextHandler)
        {
            this.Next = nextHandler;
        }
    }
}
