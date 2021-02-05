using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double   fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            TravelledDistance = 0;
            
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


        public bool Drive(Car car, int distance)
        {
            double fuelForDistance = distance * car.FuelConsumptionPerKilometer;

            if(car.FuelAmount - fuelForDistance >= 0)
            {
                car.FuelAmount -= distance * FuelConsumptionPerKilometer;
                car.TravelledDistance += distance;
                return true;
            }

            return false;
        }
    }
}
