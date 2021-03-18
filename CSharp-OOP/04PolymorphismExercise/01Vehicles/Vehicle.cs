using System;
using System.Collections.Generic;
using System.Text;

namespace _01Vehicles
{
    public abstract class Vehicle
    {
        public int FuelQuantity { get;}

        public double FuelConsumption { get;}

        public virtual void Drive(int distance)
        {
            Console.WriteLine($"{} travelled {distance} km");
        }
    }
}
