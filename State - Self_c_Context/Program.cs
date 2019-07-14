using State___Self_c_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextLogin ctx = new ContextLogin();
            NewLogin loginstate = new NewLogin(ctx);
            ctx.Init(loginstate);

            Console.WriteLine("Welcome to my website. Please enter your password");
            string password = Console.ReadLine();

            ctx.login(password);
            ctx.login("Aa123456");
            ctx.restart();
            ctx.login("12345");
            ctx.login("123");
            ctx.login("15");
            ctx.restart();
            ctx.login("123");
            ctx.login("Aa123456");
        }
    }
}
