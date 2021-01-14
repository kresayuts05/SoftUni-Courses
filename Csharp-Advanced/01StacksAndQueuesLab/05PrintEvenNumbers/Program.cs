using System;
using System.Collections.Generic;
using System.Linq;

namespace _05PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(array);

            while (queue.Count != 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    Console.Write(queue.Peek() + ", ");
                }

                queue.Dequeue();
            }
        }
    }
}
