using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstQueue = new Queue<int>(firstInput);
            Stack<int> secondStack = new Stack<int>(secondInput);

            List<int> items = new List<int>();
            while (firstQueue.Any() && secondStack.Any())
            {
                int first = firstQueue.Peek();
                int second = secondStack.Peek();

                int sum = first + second;

                if (sum % 2 == 0)
                {
                    items.Add(sum);
                    firstQueue.Dequeue();
                    secondStack.Pop();
                }
                else
                {
                    firstQueue.Enqueue(second);
                    secondStack.Pop();
                }
            }

            if (!firstQueue.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int sumItems = items.Sum();

            if (sumItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumItems}");
            }
        }
    }
}
