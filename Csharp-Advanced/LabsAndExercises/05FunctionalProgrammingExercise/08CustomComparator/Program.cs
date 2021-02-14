using System;
using System.Linq;

namespace _08CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int[]> evenNums = EvenNums;
            Func<int[], int[]> oddNums = OddNums;

            Console.WriteLine(string.Join(" ", evenNums(numbers)) + " " + string.Join(" ", oddNums(numbers)));
        }

        static int[] EvenNums(int[] array)
        {
            int[] evenNums = array.Where(a => a % 2 == 0)
                .OrderBy(a => a)
                .ToArray();

            return evenNums;
        }

        static int[] OddNums(int[] array)
        {
            int[] oddNums = array.Where(a => a % 2 == 1 || a % 2 == -1)
                .OrderBy(a => a)
                .ToArray();

            return oddNums;
        }
    }
}
