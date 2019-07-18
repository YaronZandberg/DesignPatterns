using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class ComputerForGamesBuilder : BaseComputerBuilder
    {
        protected override void MakeEnclosure()
        {
            this.Computer.MakeEnclosure("Computer for games: Making Enclosure");
        }

        protected override void AddMotherboard()
        {
            this.Computer.AddMotherboard("Computer for games: Adding motherboard");
        }

        protected override void AddProcessor()
        {
            this.Computer.AddProcessor("Computer for games: Adding strong processor");
        }

        protected override void AddGraphicCard()
        {
            this.Computer.AddGraphicCard("Computer for games: Adding strong graphical card");
        }

        protected override void AddMemory()
        {
            this.Computer.AddMemory("Computer for games: Adding many memory");
        }
    }
}
