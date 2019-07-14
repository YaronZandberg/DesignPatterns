using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public class ContextLogin
    {
        public ILoginState State { get; set; }

        public ContextLogin()
        {
        }

        public void Init(ILoginState state)
        {
            this.State = state;
        }

        public void login(string password)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
        
            State.Login(password);
        }
        
        public void restart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
        
            State.Restart();
        }
    }
}
