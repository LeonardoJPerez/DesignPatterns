using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteCalculation
{
    public class Logarithm : ICalculate<double>
    {
        /// <summary>
        /// Calculate the logarithm for value1 with base value2.
        /// </summary>
        /// <param name="value1">The value.</param>
        /// <param name="value2">The base.</param>
        /// <returns></returns>
        public double Execute(double value1, double value2)
        {
            return Math.Log(value1, value2);
        }
    }
}
