using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = parameters[0];
            int x = parameters[1];
            int s = parameters[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < x; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(s))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
