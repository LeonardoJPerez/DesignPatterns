using System;

namespace AdapterPattern.Object
{
    public class Adaptor
    {
        private Object.Adaptee _adapteeInstance;

        public Adaptor()
        {
            this._adapteeInstance = new Object.Adaptee();
        }

        public void MethodB()
        {
            if (this._adapteeInstance != null)
            {
                this._adapteeInstance.MethodA();
            }

            Console.WriteLine("Method called from Object.Adapter instance!");
        }
    }
}