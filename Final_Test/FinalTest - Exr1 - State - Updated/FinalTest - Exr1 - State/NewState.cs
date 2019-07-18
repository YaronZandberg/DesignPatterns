using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest___Exr1___State
{
    class NewState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            int currLivingPoints = status.GetLivingPoints() - points;
            status.SetLivingPoints(currLivingPoints);
            if(currLivingPoints < 10)
            {
                Console.WriteLine("You have changed to danger state, because you have: " + currLivingPoints + " living points.");
                return new DangerState();
            }
            else if (currLivingPoints <= 0 )
            {
                Console.WriteLine("You have lost because you lost all your living points.");
                return new LoseState();
            }
            else
            {
                Console.WriteLine("Now you have: " + currLivingPoints + " living points.");
                return new NewState();
            }
        }

        public override GameState LevelUp(GameStatus status)
        {
            int Level = status.GetCurrLevel() + 1;
            status.SetCurrLevel(Level);
            if(Level==4)
            {
                Console.WriteLine("Congragulations: You Have won the game!");
                return new WinState();
            }
            else
            {
                Console.WriteLine("Congragulations: You raised your level. Your level is: " + Level);
                return new NewState();
            }
        }
    }
}
