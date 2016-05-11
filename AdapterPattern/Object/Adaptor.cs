using System;

namespace AdapterPattern
{
    public class Adaptor
    {
        private Adaptee _adatpeeInstance;

        public Adaptor()
        {
            _adatpeeInstance = new Adaptee();
        }

        public void MethodB()
        {
            this._adatpeeInstance.MethodA();
            Console.WriteLine("Method called from Adapter instance!");
        }
    }
}