using System;
using System.Linq;

namespace _04AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            Func<double, double> vat = x => x += x * 0.2;

            foreach (var num in input)
            {
                Console.WriteLine($"{vat(num):f2}");
            }
;        }
    }
}
