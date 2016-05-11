using System;

namespace AdapterPattern.Class
{
    public class Client
    {
        public Class.Adaptor Adaptor { get; private set; }

        public Client()
        {
            this.Adaptor = new Class.Adaptor(new Class.Adaptee());
        }

        public void DoWork()
        {
            this.Adaptor?.MethodB();
            Console.WriteLine("Method called from Class.Client instance!");
        }
    }
}