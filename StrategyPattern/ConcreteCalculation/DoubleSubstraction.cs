namespace StrategyPattern.ConcreteCalculation
{
    public class DoubleSubstraction : ICalculate<double>
    {
        public double Execute(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}