using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public abstract class FormulaDecoratorBase : IFormula
    {
        protected IFormula StartNumber;

        public FormulaDecoratorBase(IFormula startNumber)
        {
            this.StartNumber = startNumber;
        }

        public abstract string GetFormula();

        public abstract double GetResult();
    }
}
