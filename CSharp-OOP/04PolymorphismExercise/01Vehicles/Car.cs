using System;
using System.Collections.Generic;
using System.Text;

namespace _01Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionar = 0.9;

        public Car(double fuelQuantity, double fuelConsumation, double tankCapacity) 
            : base(fuelQuantity, fuelConsumation, airConditionar, tankCapacity)
        {
        }
    }
}
