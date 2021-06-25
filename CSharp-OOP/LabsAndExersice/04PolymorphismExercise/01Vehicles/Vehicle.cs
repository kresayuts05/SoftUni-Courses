using System;
using System.Collections.Generic;
using System.Text;

namespace _01Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumation, double airConditioner, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            TankCapacity = tankCapacity;
            FuelConsumation = fuelConsumation;
            AirConditionar = airConditioner;
        }

        public double FuelQuantity 
        { 
            get => fuelQuantity;
            protected set
            {
                if(value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumation { get; private set; }

        public double TankCapacity { get; private set; }

        private double AirConditionar { get; set; }

        public void Drive(double distance)
        {
            double needFuel = (FuelConsumation + AirConditionar) * distance;

            if (needFuel > FuelQuantity)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= needFuel;
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            if (fuel + FuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
                throw new InvalidOperationException($"Cannot fit {fuel + FuelQuantity} fuel in the tank");
            }

            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
