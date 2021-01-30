using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int start = bounds[0];
            int end = bounds[1];

            Func<string, int, int, List<int>> printArray = PrintArray;

            Console.WriteLine(string.Join(" ", printArray(command, start, end)));
        }

        static List<int> PrintArray(string command, int start, int end)
        {
            List<int> output = new List<int>();

            if (command == "odd")
            {
                if (start % 2 == 1)
                {
                    for (int i = start; i <= end; i += 2)
                    {
                        output.Add(i);
                    }
                }
                else
                {
                    for (int i = start + 1; i <= end; i += 2)
                    {
                        output.Add(i);
                    }
                }
            }
            else if (command == "even")
            {

                if (start % 2 == 0)
                {
                    for (int i = start; i <= end; i += 2)
                    {
                        output.Add(i);
                    }
                }
                else
                {
                    for (int i = start + 1; i <= end; i += 2)
                    {
                        output.Add(i);
                    }
                }
            }

            return output;
        }

    }
}
