﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class FatalHandle : LogHandlerBase
    {
        private const string LOGLEVEL = "Fatal";
        public override void PrintLog(string message, string level)
        {
            if (LOGLEVEL.Equals(level))
            {
                Console.WriteLine(LOGLEVEL + ": " + message);
            }
            else if (next != null)
            {
                next.PrintLog(message, level);
            }
            else
            {
                return;
            }
        }
    }
}