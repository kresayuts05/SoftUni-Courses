using System;

namespace _01Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine()
                .Split();

            string[] truckInput = Console.ReadLine()
                .Split();

            string[] busInput = Console.ReadLine()
                .Split();

            Car car = null;
            Truck truck = null;
            Bus bus = null;
            try
            {
                car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));

                truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));

                bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));


            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string command = input[0];
                string type = input[1];
                double parameter = double.Parse(input[2]);

                if (command == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Drive(parameter);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Drive(parameter);
                        }
                        else
                        {
                            bus.Drive(parameter);
                        }

                        Console.WriteLine($"{type} travelled {parameter} km");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Refuel(parameter);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Refuel(parameter);
                        }
                        else
                        {
                            bus.Refuel(parameter);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        bus.DriveEmpty(parameter);
                        Console.WriteLine($"{type} travelled {parameter} km");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
