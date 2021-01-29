using System;
using System.Linq;

namespace _03CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printUpperCase = PrintUpperCase;

            printUpperCase(input);

        }

        static void PrintUpperCase(string[] array)
        {
            foreach (var word in array)
            {
                if((int)word[0] >= 50 && (int)word[0] <= 90 )
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
