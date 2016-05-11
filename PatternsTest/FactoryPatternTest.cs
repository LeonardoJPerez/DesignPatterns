using System;
using FactoryPattern;
using NUnit.Framework;

namespace PatternsTest
{
    [TestFixture]
    public class FactoryPatternTest
    {
        [Test]
        public void RunTest()
        {
            var carFactory = new CarFactory();

            Console.WriteLine("Creating Mustang vehicle...");
            var mustang = carFactory.CreateVehicle(CarType.Mustang);

            mustang.StartEngine();
            mustang.StopEngine();

            Console.WriteLine("Creating Nissan GTR vehicle...");
            var gtr = carFactory.CreateVehicle(CarType.NissanGTR);

            gtr.StartEngine();
            gtr.StopEngine();

            Assert.Pass();
        }
    }
}