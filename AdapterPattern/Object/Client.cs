using System;

namespace AdapterPattern.Object
{
    public class Client
    {
        public Object.Adaptor Adaptor { get; private set; }

        public Client()
        {
            this.Adaptor = new Object.Adaptor();
        }

        public void DoWork()
        {
            this.Adaptor.MethodB();
            Console.WriteLine("Method called from Object.Client instance!");
        }
    }
}