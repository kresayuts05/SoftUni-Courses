using System;
using System.Collections.Generic;
using System.Text;

namespace _01Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionar = 1.6;

        public Truck(double fuelQuantity, double fuelConsumation, double tankCapacity)
            : base(fuelQuantity , fuelConsumation, airConditionar, tankCapacity)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);
        }
    }
}
