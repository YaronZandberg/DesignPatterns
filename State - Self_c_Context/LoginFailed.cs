using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public class LoginFailed : StateLoginBase
    {
        private int tries = 2;
        public LoginFailed(ContextLogin ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            if (tries > 0)
            {
                if (PASSWORD.Equals(password))
                {
                    Console.WriteLine("Great! You have logged in!");
                    ctx.State = new LoginSucceed(ctx);
                }
                else
                {
                    Console.WriteLine("Wrong password");
                    tries--;
                }
            }

            ctx.State = new Locked(ctx);
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
