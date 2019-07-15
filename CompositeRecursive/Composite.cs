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

        public Composite(string name) : base(name)
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
            Console.WriteLine(space + this.name);
            //foreach (Component c in childs)
            //{
            //    c.Draw(space + "    ");
            //}
        }

        public override bool IsBinary()
        {
            //if (this.GetChilds().Count() == 0)
            //{
            //    return true;
            //}
            //else if (this.GetChilds().Count() != 2)
            //{
            //    return false;
            //}
            //else
            //{
            //    return (this.GetChilds().First().IsBinary()) && (this.GetChilds().Last().IsBinary());
            //}


            return ((this.GetChilds().Count() == 0) || (this.GetChilds().Count() == 2));
        }
    }
}
