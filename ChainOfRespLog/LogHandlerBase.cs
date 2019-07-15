using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase next;

        public abstract void PrintLog(string message, string level);

        public void SetNext(LogHandlerBase next)
        {
            this.next = next;
        }
    }
}
