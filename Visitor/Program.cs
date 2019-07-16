using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Perfume perf = new Perfume(100);
            ShopRent shop = new ShopRent(10000);

            Console.WriteLine(vodka);
            Console.WriteLine(perf);
            Console.WriteLine(shop);

            IVisitor endOfYearVisitor = new EndOfYearTax();
            IVisitor oneShekelSaleVisitor = new OneShekelSaleTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");
            Console.WriteLine($"Price after tax = {perf.Accept(endOfYearVisitor)}");
            Console.WriteLine($"One shekel sale = {vodka.Accept(oneShekelSaleVisitor)}");
            Console.WriteLine($"One shekel sale = {perf.Accept(oneShekelSaleVisitor)}");
            Console.WriteLine($"Price after tax = {shop.Accept(endOfYearVisitor)}");
            Console.WriteLine($"One shekel sale = {shop.Accept(oneShekelSaleVisitor)}");
        }
    }
}
