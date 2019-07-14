using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public abstract class StateLoginBase : ILoginState
    {
        protected ContextLogin ctx;
        protected const string PASSWORD = "Aa123456";

        public StateLoginBase(ContextLogin ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);

        public abstract void Restart();
    }
}
