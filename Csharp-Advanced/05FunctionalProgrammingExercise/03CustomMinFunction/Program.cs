using System;
using System.Linq;

namespace _03CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minFunc = MinFunc;
            Console.WriteLine(minFunc(array));
        }

        static int MinFunc(int[] array)
        {
            int min = int.MaxValue;
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}
