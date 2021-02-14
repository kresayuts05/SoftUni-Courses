using System;
using System.Collections.Generic;
using System.Linq;

namespace _07TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(input[0]);
                queue.Enqueue(input[1]);
            }

            int index = 0;
            int currIndex = 0;
            int amountPetrol = 0;
            int distance = 0;

            while (true)
            {
                int sum = 0;
                currIndex = index;

                while (currIndex < queue.Count() / 2 - 1)
                {
                    amountPetrol = queue.Dequeue();
                    distance = queue.Dequeue();

                    queue.Enqueue(amountPetrol);
                    queue.Enqueue(distance);
                    currIndex++;

                    sum += amountPetrol - distance;

                    if (sum < 0)
                    {
                        while (currIndex < queue.Count() / 2 - 1)
                        {
                            amountPetrol = queue.Dequeue();
                            distance = queue.Dequeue();

                            queue.Enqueue(amountPetrol);
                            queue.Enqueue(distance);
                            currIndex++;
                        }

                        index++;
                        break;
                    }

                }

                if (sum >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }

                index++;
            }
        }
    }
}
