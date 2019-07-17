﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public class SubDecorator : FormulaDecoratorBase
    {
        private double AdditionalNumber { get; set; }
        public SubDecorator(IFormula startNumber, double additionalNumber) : base(startNumber)
        {
            this.AdditionalNumber = additionalNumber;
        }

        public override string GetFormula()
        {
            return StartNumber.GetFormula() + " - " + AdditionalNumber.ToString();
        }

        public override double GetResult()
        {
            return (StartNumber.GetResult() - AdditionalNumber);
        }
    }
}
