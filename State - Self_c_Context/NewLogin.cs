using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public class NewLogin : StateLoginBase
    {
        public NewLogin(ContextLogin ctx) : base(ctx)
        {

        }

        public override void Login(string pass)
        {
            if (PASSWORD.Equals(pass))
            {
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                ctx.State = new LoginFailed(ctx);
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
