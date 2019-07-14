using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Singleton
    {
        private static Singleton INSTANCE;

        private static object key = new object();
        private Singleton()
        {

        }
        public void getDate()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static Singleton GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Singleton();
                }
            }

            return INSTANCE;
        }        
    }
}
