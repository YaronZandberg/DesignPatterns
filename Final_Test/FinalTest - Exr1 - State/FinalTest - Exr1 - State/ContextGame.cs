using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class ContextGame
    {
        public GameState currState;
        public GameStatus currStatus;
        public ContextGame()
        {
            this.currState = new NewState();
            this.currStatus = new GameStatus();
        }

        public void gotHit(int points)
        {
            this.currState = this.currState.GetHit(this.currStatus, points);
        }

        public void LevelUp()
        {
            this.currState = this.currState.LevelUp(this.currStatus);
        }

    }
}
