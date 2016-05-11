using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface ICalculate<TType>
    {
        TType Execute(TType value1, TType value2);
    }
}
