using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int currNumber = 0; 
            for (int i = 0; i < n; i++)
            {
                currNumber = int.Parse(Console.ReadLine());

                firstSet.Add(currNumber);
            }

            for (int i = n; i < n + m; i++)
            {
                currNumber = int.Parse(Console.ReadLine());

                secondSet.Add(currNumber);
            }

            foreach (var num in firstSet)
            {
                if(secondSet.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
