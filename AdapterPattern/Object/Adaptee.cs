using System;

namespace AdapterPattern.Object
{
    public class Adaptee
    {
        public void MethodA()
        {
            Console.WriteLine("Method called from Object.Adaptee instance!");
        }
    }
}