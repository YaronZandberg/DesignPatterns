using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest___Exr1___State
{
    class LoseState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("You have already lost!");
            return new LoseState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("You have already lost!");
            return new LoseState();
        }
    }
}
