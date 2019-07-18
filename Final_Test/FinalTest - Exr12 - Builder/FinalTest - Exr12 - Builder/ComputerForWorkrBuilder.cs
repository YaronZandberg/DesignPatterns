using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class ComputerForWorkrBuilder : BaseComputerBuilder
    {
        protected override void MakeEnclosure()
        {
            this.Computer.MakeEnclosure("Computer for work: Making Enclosure");
        }

        protected override void AddMotherboard()
        {
            this.Computer.AddMotherboard("Computer for work: Adding normal motherboard");
        }

        protected override void AddProcessor()
        {
            this.Computer.AddProcessor("Computer for work: Adding normal processor");
        }

        protected override void AddGraphicCard()
        {
            this.Computer.AddGraphicCard("Computer for work: Adding normal graphical card");
        }

        protected override void AddMemory()
        {
            this.Computer.AddMemory("Computer for work: Adding normal memory");
        }
    }
}
