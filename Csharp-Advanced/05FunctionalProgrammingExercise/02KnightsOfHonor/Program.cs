using System;

namespace _02KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
             
            Action<string> action = w => Console.WriteLine("Sir " + w);

            foreach (var word in input)
            {
                action(word);
            }
        }
    }
}
