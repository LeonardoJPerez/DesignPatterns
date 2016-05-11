using FactoryPattern.ConcreteVehicles;
using System;

namespace FactoryPattern
{
    public class CarFactory
    {
        public IVehicle CreateVehicle(CarType type)
        {
            switch (type)
            {
                case CarType.Mustang:
                    return new Mustang();

                case CarType.NissanGTR:
                    return new NissanGTR();

                default:
                    throw new NotSupportedException("Option not supported!");
            }
        }
    }
}