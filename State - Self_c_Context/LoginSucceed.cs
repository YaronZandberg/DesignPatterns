using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public class LoginSucceed : StateLoginBase
    {
        public LoginSucceed(ContextLogin ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            Console.WriteLine("You have already logged in...");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
