using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class ChangeStrategy
    {
        public ChangeStrategy(char @operator)
        {
            this.@Operator = @operator;
        }
        public int @Operator { get; set; }


    }
}
