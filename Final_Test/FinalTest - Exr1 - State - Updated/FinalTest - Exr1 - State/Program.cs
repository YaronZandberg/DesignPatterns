using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest___Exr1___State
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextGame ctxGameLose = new ContextGame();
            ctxGameLose.LevelUp();
            ctxGameLose.gotHit(12);
            ctxGameLose.gotHit(30);
            ctxGameLose.gotHit(60);
            ctxGameLose.LevelUp();

            Console.WriteLine();

            ContextGame ctxGameWin = new ContextGame();
            ctxGameWin.LevelUp();
            ctxGameWin.gotHit(18);
            ctxGameWin.LevelUp();
            ctxGameWin.LevelUp();
            ctxGameWin.LevelUp();
            ctxGameWin.gotHit(100);

        }
    }
}
