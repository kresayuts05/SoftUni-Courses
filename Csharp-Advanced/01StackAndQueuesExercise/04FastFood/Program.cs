using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count() > 0)
            {
                if (quantityFood - queue.Peek() >= 0)
                {
                    quantityFood -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", queue));
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
