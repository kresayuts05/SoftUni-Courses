using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(model, car);
            }

            //"Drive {carModel} {amountOfKm}"
            string token = Console.ReadLine();
            while (token != "End")
            {
                string[] command = token.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = command[1];
                int amountKM = int.Parse(command[2]);

                if (cars.ContainsKey(carModel))
                {
                    if (cars[carModel].Drive(cars[carModel], amountKM) == false)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }

                token = Console.ReadLine();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
