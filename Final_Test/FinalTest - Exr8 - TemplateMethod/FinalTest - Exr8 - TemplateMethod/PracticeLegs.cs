﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PracticeLegs : PracticeTemplateBase
    {
        protected override void ExecuteWork()
        {
            Console.WriteLine("     Executing legs execise ...");
        }
    }
}
