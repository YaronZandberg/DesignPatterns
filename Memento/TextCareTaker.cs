using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> mementoList = new List<TextMemento>();
        int index = -1;

        public void AddMemento(TextMemento memento)
        {
            this.mementoList.Add(memento);
            this.index++;
            mementoList.RemoveRange(index, (mementoList.Count - index - 1));
        }

        public TextMemento GetPrev()
        {
            if (index != -1 && index < this.mementoList.Count())
            {
                this.index--;
                return this.mementoList[index + 1];
            }

            this.index = 0;
            return null;
        }

        public TextMemento GetNext()
        {
            if (index != -1 && index + 1 < this.mementoList.Count())
            {
                this.index++;
                return this.mementoList[index];
            }
            else if (index == -1)
            {
                index = 0;
            }

            return null;
        }
    }
}
