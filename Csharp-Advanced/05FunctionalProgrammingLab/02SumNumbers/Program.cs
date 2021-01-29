    using System;
    using System.Linq;

    namespace _02SumNumbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] input = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                Func<int[], int> printCount = x => x.Length;
                Func<int[], int> printSum = x => x.Sum();

                Console.WriteLine(printCount(input));
                Console.WriteLine(printSum(input));
            }
        }
    }
