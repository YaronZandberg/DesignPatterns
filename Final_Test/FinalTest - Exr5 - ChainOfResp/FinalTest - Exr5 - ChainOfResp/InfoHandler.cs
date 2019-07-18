using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class InfoHandler : LogHandlerBase
    {
        private const int LEVEL = 3;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("info: " + log);
            }
            else if (this.Next != null)
            {
                this.Next.Handle(log, level);
            }
        }
    }
}
