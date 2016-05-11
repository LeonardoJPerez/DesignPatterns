using System;

namespace ObserverPattern.Concrete
{
    public class ConcreteObserverB : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notifying from Concrete Observer B!");
        }
    }
}