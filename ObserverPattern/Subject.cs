using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        public IList<IObserver> Listeners { get; private set; }

        public void RegisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                this.Listeners.Add(observer);
            }
        }

        public void UnRegisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                this.Listeners.Remove(observer);
            }
        }

        public void NotifyListeners()
        {
            foreach (IObserver o in this.Listeners)
            {
                o.Notify();
            }
        }
    }
}