using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Computer
    {
        private List<String> Component = new List<String>();

        public Computer()
        {
            // MakeEnclosure
            // AddMotherboard
            // AddProcessor
            // AddGraphicCard
            // AddMemory
        }

        public void MakeEnclosure(string Enclosure)
        {
            Component.Add(Enclosure);
        }

        public void AddMotherboard(string motherboard)
        {
            Component.Add(motherboard);
        }

        public void AddProcessor(string processor)
        {
            Component.Add(processor);
        }

        public void AddGraphicCard(string graphicCard)
        {
            Component.Add(graphicCard);
        }

        public void AddMemory(string memory)
        {
            Component.Add(memory);
        }

        public override string ToString()
        {
            return $"\n  Enclosure: {Component[0]} \n  Motherboard: {Component[1]} \n  Processor: {Component[2]} \n  GraphicCard: {Component[3]} \n  Memory: {Component[4]} \n";
        }
    }
}
