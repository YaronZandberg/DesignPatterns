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
            BillHandlerBase billhandle500 = new BillHandle500();
            BillHandlerBase billHandler200 = new BillHandler200();
            BillHandlerBase billHandler100 = new BillHandle100();
            BillHandlerBase billHandler25 = new BillHandle25();
            BillHandlerBase coinHandler5 = new CoinHandler5();
            BillHandlerBase coinhandle2 = new CoinHandle2();

            BillHandlerBase chainRoot = billhandle500;
            billhandle500.SetNext(billHandler200);
            billHandler200.SetNext(billHandler100);
            billHandler100.SetNext(billHandler25);
            billHandler25.SetNext(coinHandler5);
            coinHandler5.SetNext(coinhandle2);

            Console.WriteLine("385:");
            chainRoot.Handle(385);
            Console.WriteLine("==================");
            Console.WriteLine("400:");
            chainRoot.Handle(400);
            Console.WriteLine("==================");
            Console.WriteLine("702:");
            chainRoot.Handle(702);
        }
    }
}
