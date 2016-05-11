using System;

namespace ObserverPattern.Concrete
{
    internal class ConcreteObserverA : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notifying from Concrete Observer A!");
        }
    }
}