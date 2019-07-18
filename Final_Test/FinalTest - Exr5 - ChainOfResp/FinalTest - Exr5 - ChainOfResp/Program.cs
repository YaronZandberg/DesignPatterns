using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase infoHandler = new InfoHandler();
            LogHandlerBase errorHandler = new ErrorHandler();
            LogHandlerBase fatalHandler = new FatalHandler();


            LogHandlerBase chainRoot = infoHandler;
            infoHandler.SetNext(errorHandler);
            errorHandler.SetNext(fatalHandler);

            Console.WriteLine("Some error log", 2);
            chainRoot.Handle("Some error log", 2);
            Console.WriteLine("==================");
            Console.WriteLine("Some fatal log", 1);
            chainRoot.Handle("Some fatal log", 1);
            Console.WriteLine("==================");
            Console.WriteLine("Some info log", 3);
            chainRoot.Handle("Some info log", 3);
            Console.WriteLine("==================");
        }
    }
}
