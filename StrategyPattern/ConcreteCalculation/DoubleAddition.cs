namespace StrategyPattern.ConcreteCalculation
{
    public class DoubleAddition : ICalculate<double>
    {
        public double Execute(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}