using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteVehicles
{
    internal class Mustang : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting Mustang engine!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stoppping Mustang engine!");
        }
    }
}
