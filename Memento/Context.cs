using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void LoadPrev(RichTextBox richText)
        {
            TextMemento prevMemento = careTake.GetPrev();
            if (prevMemento != null && prevMemento.savedText != null)
            {
                richText.Text = prevMemento.savedText;
            }

        }

        public void LoadNext(RichTextBox richText)
        {
            TextMemento nextMemento = careTake.GetNext();
            if (nextMemento != null && nextMemento.savedText != null)
            {
                richText.Text = nextMemento.savedText;
            }
        }
    }
}
