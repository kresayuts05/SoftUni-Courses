using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
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

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < x; i++)
            {
                stack.Dequeue();
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
