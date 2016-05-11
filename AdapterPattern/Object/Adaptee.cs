using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adaptee
    {
        public void MethodA()
        {
            Console.WriteLine("Method called from Adaptee instance!");
        }
    }
}
