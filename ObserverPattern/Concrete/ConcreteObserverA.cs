using System;

namespace ObserverPattern.Concrete
{
    public class ConcreteObserverA : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notifying from Concrete Observer A!");
        }
    }
}