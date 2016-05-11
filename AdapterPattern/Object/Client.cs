using System;

namespace AdapterPattern.Object
{
    public class Client : Adaptor
    {
        public void DoWork()
        {
            this.MethodB();
            Console.WriteLine("Method called from Client instance!");
        }
    }
}