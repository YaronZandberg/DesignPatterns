using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class WinState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("You have already win the game! Well done!");
            return new WinState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("You have already win the game! Well done!");
            return new WinState();
        }
    }
}