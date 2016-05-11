using ObserverPattern.Concrete;
using System;

namespace ObserverPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var o1 = new ConcreteObserverA();
            var o2 = new ConcreteObserverB();

            var subject = new Subject();
            subject.RegisterObserver(o1);
            subject.RegisterObserver(o2);

            subject.NotifyListeners();

            Console.ReadLine();
        }
    }
}