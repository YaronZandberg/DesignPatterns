using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugHandle debug= new DebugHandle();
            InfoHandle info = new InfoHandle();
            ErrorHandle error = new ErrorHandle();
            FatalHandle fatal = new FatalHandle();
            
            LogHandlerBase chainRoot = debug;
            debug.SetNext(info);
            info.SetNext(error);
            error.SetNext(fatal);
            fatal.SetNext(null);
            
            // Using first chain: Debug --> Info --> Error --> Fatal
            chainRoot.PrintLog("This is a Fatal log", "Fatal");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Info log", "Info");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Debug log", "Debug");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Error log", "Error");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Error log", "AAA");
            Console.WriteLine("==================");

            //DebugHandle debug = new DebugHandle();
            //InfoHandle info = new InfoHandle();
            //ErrorHandle error = new ErrorHandle();
            //FatalHandle fatal = new FatalHandle();
            //
            chainRoot = fatal;
            fatal.SetNext(error);
            error.SetNext(info);
            info.SetNext(debug);
            debug.SetNext(null);
            
            // Using first chain: Fatal --> Error --> Info --> Debug
            chainRoot.PrintLog("This is a Fatal log", "Fatal");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Info log", "Info");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Debug log", "Debug");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Error log", "Error");
            Console.WriteLine("==================");
            chainRoot.PrintLog("This is an Error log", "AAA");
            Console.WriteLine("==================");
        }
    }
}
