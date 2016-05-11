using NUnit.Framework;
using ObserverPattern;
using ObserverPattern.Concrete;
using System;

namespace PatternsTest
{
    [TestFixture]
    public class ObserverPatternTest
    {
        [Test]
        public void Run()
        {
            var o1 = new ConcreteObserverA();
            var o2 = new ConcreteObserverB();

            var subject = new Subject();
            subject.RegisterObserver(o1);
            subject.RegisterObserver(o2);

            subject.NotifyListeners();

            Console.WriteLine("Listeners notified!");
            Assert.Pass();
        }
    }
}