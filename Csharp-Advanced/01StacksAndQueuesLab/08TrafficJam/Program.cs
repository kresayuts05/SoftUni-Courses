using System;
using System.Collections.Generic;

namespace _08TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCarsCount = 0;

            while (command != "end")
            {

                if (command == "green")
                {
                    for (int i = 0  ; i < n; i++)
                    {
                        if(cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCarsCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");
        }
    }
}
