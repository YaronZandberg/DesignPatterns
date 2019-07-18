using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class ErrorHandler : LogHandlerBase
    {
        protected const int LEVEL = 2;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("ERROR: " + log);
                WriteToFile(log);
            }
            else if (this.Next != null)
            {
                this.Next.Handle(log, level);
            }
        }

        private void WriteToFile(string log)
        {
            Console.WriteLine("Writing error to file...");
            File.AppendAllText(@"C:\Users\HackerU\source\repos\Final_Test\FinalTest - Exr5 - ChainOfResp\FinalTest - Exr5 - ChainOfResp\log.txt", Environment.NewLine + "ERROR: " + log);
        }
    }
}
