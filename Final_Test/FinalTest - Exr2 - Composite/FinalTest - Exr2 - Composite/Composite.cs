using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int Sum()
        {
            int sum = this.Number;
            foreach (Component currComponent in childs)
            {
                sum += currComponent.Sum();
            }
            return sum;
        }

        public override bool IsEven()
        {
            // If the composite's value isn't even, return false
            if (this.Number % 2 == 1)
            {
                return false;
            }
            // The value is even, check if the composite doesn't have childs
            else if (this.GetChilds().Count == 0)
            {
                return true;
            }
            // The value is even and the composite has childs.
            // Activate the function on the composite's childs/
            else
            {
                bool currEven = true;
                foreach (Component currComponent in this.GetChilds())
                {
                    currEven = currEven && currComponent.IsEven();
                }
                return currEven;
            }
        }
    }
}
