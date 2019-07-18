using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class ComputerFactory
    {
        public Computer ProduceComputer(string computerType)
        {
            if (computerType.Equals("Games"))
            {
                ComputerForGamesBuilder computerForGames = new ComputerForGamesBuilder();
                computerForGames.BuildComputer();
                return (computerForGames.GetComputer());
            }
            else if (computerType.Equals("Work"))
            {
                ComputerForWorkrBuilder computerForWork = new ComputerForWorkrBuilder();
                computerForWork.BuildComputer();
                return (computerForWork.GetComputer());
            }
            else if (computerType.Equals("LivingRoom"))
            {
                ComputerForLivingRoomBuilder computerForLivingRoom = new ComputerForLivingRoomBuilder();
                computerForLivingRoom.BuildComputer();
                return (computerForLivingRoom.GetComputer());
            }
            else
            {
                throw new Exception("This type of computer isn't exist");
            }
        }
    }
}
