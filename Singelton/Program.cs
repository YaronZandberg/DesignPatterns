using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Singleton s3 = Singleton.GetInstance();

            s1.getDate();
            s2.getDate();
            s3.getDate();
        }
    }
}
