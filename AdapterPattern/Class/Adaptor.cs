using System;

namespace AdapterPattern.Class
{
    public class Adaptor
    {
        private Class.IAdaptee _adapteeInstance;

        public Adaptor(Class.IAdaptee adaptee)
        {
            _adapteeInstance = adaptee;
        }

        public void MethodB()
        {
            this._adapteeInstance?.MethodA();
            Console.WriteLine("Method called from Class.Adapter instance!");
        }
    }
}