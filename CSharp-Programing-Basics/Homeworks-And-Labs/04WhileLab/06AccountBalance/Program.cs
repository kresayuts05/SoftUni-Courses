﻿using System;

namespace _06AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int steps = 0;
            int stepsSum = 0;
            int stepsToHome = 0;

            while (command != "Going home")
            {
                steps = int.Parse(command);
                stepsSum = stepsSum + steps;
                if (stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                stepsToHome = int.Parse(Console.ReadLine());
                if ((stepsSum + stepsToHome) >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000 - (stepsSum + stepsToHome)} more steps to reach goal.");
                }
            }
        }
    }
}
