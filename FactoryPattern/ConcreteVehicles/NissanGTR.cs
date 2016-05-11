using System;

namespace FactoryPattern.ConcreteVehicles
{
    internal class NissanGTR : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting Nissan GTR engine!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping Nissan GTR engine!");
        }
    }
}