using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public abstract class BaseComputerBuilder
    {
        protected Computer Computer;

        public Computer GetComputer()
        {
            if (this.Computer == null)
                throw new Exception("The computer isn't ready!");

            return this.Computer;
        }

        public void BuildComputer()
        {
            this.Computer = new Computer();
            MakeEnclosure();
            AddMotherboard();
            AddProcessor();
            AddGraphicCard();
            AddMemory();
        }

        protected abstract void MakeEnclosure();

        protected abstract void AddMotherboard();

        protected abstract void AddProcessor();

        protected abstract void AddGraphicCard();

        protected abstract void AddMemory();
    }
}
