using System;
using System.Collections.Generic;

namespace _04GenericSwapMethodInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            string[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);

            GenericClass<int> generic = new GenericClass<int>();

            List<int> output = generic.Swap(list, firstIndex, secondIndex);

            foreach (var item in output)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
    