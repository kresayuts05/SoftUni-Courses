using System;
using System.Collections.Generic;

namespace _06Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            string[] separators = { " -> ", "," };

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if (!wardrobe[input[0]].ContainsKey(input[j]))
                    {
                        wardrobe[input[0]].Add(input[j], 0);
                    }

                    wardrobe[input[0]][input[j]]++;
                }
            }

            string[] searching = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes: ");

                foreach (var cloth in color.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");

                    if (searching[0] == color.Key && searching[1] == cloth.Key)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
