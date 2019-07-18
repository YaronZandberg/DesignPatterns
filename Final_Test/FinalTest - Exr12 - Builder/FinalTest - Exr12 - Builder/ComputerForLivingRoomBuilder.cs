using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class ComputerForLivingRoomBuilder : BaseComputerBuilder
    {
        protected override void MakeEnclosure()
        {
            this.Computer.MakeEnclosure("Computer for living room: Making thin Enclosure");
        }

        protected override void AddMotherboard()
        {
            this.Computer.AddMotherboard("Computer for living room: Adding thin motherboard");
        }

        protected override void AddProcessor()
        {
            this.Computer.AddProcessor("Computer for living room: Adding normal processor");
        }

        protected override void AddGraphicCard()
        {
            this.Computer.AddGraphicCard("Computer for living room: Adding strong graphical card");
        }

        protected override void AddMemory()
        {
            this.Computer.AddMemory("Computer for living room: Adding memory");
        }
    }
}
