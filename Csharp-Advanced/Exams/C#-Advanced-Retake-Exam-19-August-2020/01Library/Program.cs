using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>();
            Queue<int> roses = new Queue<int>();

            int[] liliesArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x >= 0)
                .ToArray();
            foreach (var item in liliesArray)
            {
                lilies.Push(item);
            }

            int[] rosesArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x >= 0)
                .ToArray();
            foreach (var item in rosesArray)
            {
                roses.Enqueue(item);
            }

            int wreaths = 0;
            int stored = 0;

            while (roses.Count != 0 && lilies.Count != 0)
            {
                int lily = lilies.Peek();
                int rose = roses.Peek();
                int sum = rose + lily;

                if (sum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum >= 15)
                {
                    while (sum > 15)
                    {
                        lily -= 2;
                        sum -= 2;
                    }

                    if (sum == 15)
                    {
                        wreaths++;
                        lilies.Pop();
                        roses.Dequeue();
                    }
                    else
                    {
                        stored += sum;
                        lilies.Pop();
                        roses.Dequeue();
                    }
                }
                else
                {
                    stored += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            if (stored != 0)
            {
                wreaths += stored / 15;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
