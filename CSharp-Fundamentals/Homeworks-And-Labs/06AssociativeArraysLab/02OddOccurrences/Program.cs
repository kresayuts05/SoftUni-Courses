using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                            .Split(" ")
                            .ToArray();

            var result = elements
                .Select(x => x.ToLower());

            var count = new Dictionary<string, int>();

            foreach (var element in result)
            {
                if (!count.ContainsKey(element))
                {
                    count[element] = 1;
                }
                else
                {
                    count[element]++;
                }
            }

            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
