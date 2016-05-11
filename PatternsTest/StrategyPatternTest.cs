using NUnit.Framework;
using StrategyPattern;
using StrategyPattern.ConcreteCalculation;
using System;

namespace PatternsTest
{
    [TestFixture]
    public class StrategyPatternTest
    {
        [Test]
        public void RunDoubleAdditionTest()
        {
            var doubleAddition = new DoubleAddition();
            var strategy = new Context<double>(doubleAddition);

            var result = strategy.Calculate(3.00, 10.00);

            Console.WriteLine($"3.00 + 10.00 = {result}");
            Assert.AreEqual(13.00, result);
        }

        [Test]
        public void RunDoubleSubstractionTest()
        {
            var doubleSubstraction = new DoubleSubstraction();
            var strategy = new Context<double>(doubleSubstraction);

            var result = strategy.Calculate(3.00, 10.00);

            Console.WriteLine($"3.00 - 10.00 = {result}");
            Assert.AreEqual(-7.00, result);
        }

        [Test]
        public void RunLogarithmTest()
        {
            var logarithm = new Logarithm();
            var strategy = new Context<double>(logarithm);

            var result = strategy.Calculate(64.00, 2.00);

            Console.WriteLine($"log base(2) of 64 = {result}");
            Assert.AreEqual(6.00, result);
        }
    }
}