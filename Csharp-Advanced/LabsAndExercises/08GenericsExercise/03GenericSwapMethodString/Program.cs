using System;
using System.Collections.Generic;

namespace _03GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            for (int i = 0; i < n ; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            string[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);

            GenericClass<string> generic = new GenericClass<string>();

           List<string> output = generic.Swap(list, firstIndex, secondIndex);

            foreach (var item in output)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
