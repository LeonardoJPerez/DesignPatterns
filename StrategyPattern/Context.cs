namespace StrategyPattern
{
    public class Context<TType>
    {
        public ICalculate<TType> CalculationStrategy { get; private set; }

        public Context(ICalculate<TType> strategy)
        {
            if (strategy == null)
            {
                throw new System.ArgumentNullException("Strategy must not be null.");
            }

            this.CalculationStrategy = strategy;
        }

        public TType Calculate(TType value1, TType value2)
        {
            return this.CalculationStrategy.Execute(value1, value2);
        }
    }
}