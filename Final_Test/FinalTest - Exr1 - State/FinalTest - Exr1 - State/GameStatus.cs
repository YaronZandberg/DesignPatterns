using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class GameStatus
    {
        int LivingPoints;
        int CurrLevel;
        public GameStatus()
        {
            this.LivingPoints = 50;
            this.CurrLevel = 1;
        }

        public int GetLivingPoints()
        {
            return this.LivingPoints;
        }
        public int GetCurrLevel()
        {
            return this.CurrLevel;
        }

        public void SetLivingPoints(int livingPoints)
        {
            this.LivingPoints = livingPoints;
        }

        public void SetCurrLevel(int currentLevel)
        {
            this.CurrLevel = currentLevel;
        }
    }
}
