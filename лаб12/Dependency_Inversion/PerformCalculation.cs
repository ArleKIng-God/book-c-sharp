using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class PerformCalculation
    {
        public PerformCalculation(int firstOperand, int secondOperand)
        {
            this.FirstOperand = firstOperand;
            this.SecondOperand = secondOperand;
        }
        public int SecondOperand { get; set; }
        public int FirstOperand { get; set; }
    }
}
