    using System;
using System.Linq;

namespace _04LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .OrderByDescending(x => x)
                           .Take(3)
                           .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
