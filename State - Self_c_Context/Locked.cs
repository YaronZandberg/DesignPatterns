using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public class Locked : StateLoginBase
    {
        public Locked(ContextLogin ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            Console.WriteLine("You have locked yourself");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
