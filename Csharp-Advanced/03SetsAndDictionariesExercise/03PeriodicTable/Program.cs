using System;
using System.Collections.Generic;

namespace _03PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in input)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
