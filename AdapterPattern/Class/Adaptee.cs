using System;

namespace AdapterPattern.Class
{
    public class Adaptee : IAdaptee
    {
        public void MethodA()
        {
            Console.WriteLine("Method called from Class.Adaptee instance!");
        }
    }
}