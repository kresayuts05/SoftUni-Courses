using System;

namespace _01ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> action = w => Console.WriteLine(w);

            foreach (var word in input)
            {
                action(word);
            }
        }
    }
}
