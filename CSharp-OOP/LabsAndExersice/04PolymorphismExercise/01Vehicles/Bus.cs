using System;
using System.Collections.Generic;
using System.Text;

namespace _01Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionar = 1.4;

        public Bus(double fuelQuantity, double fuelConsumation, double tankCapacity) 
        : base(fuelQuantity, fuelConsumation, airConditionar, tankCapacity)
        {   
        }

        
        public void DriveEmpty(double distance)
        {
            double needFuel = FuelConsumation * distance;

            if (needFuel > FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= needFuel;
        }
    }
}
