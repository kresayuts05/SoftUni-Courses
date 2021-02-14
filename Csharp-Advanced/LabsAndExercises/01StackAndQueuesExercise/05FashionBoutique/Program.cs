using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(box);

            int rack = 0;
            if (stack.Count() != 0)
            {
                rack = 1;
            }

            int currRackCapacity = capacity;
            while (stack.Any())
            {
                if (currRackCapacity - stack.Peek() >= 0 && stack.Count() > 0)
                {
                    int cloth = stack.Pop();
                    currRackCapacity -= cloth;
                }
                else
                {
                    rack++;
                    currRackCapacity = capacity;
                }
            }

            Console.WriteLine(rack);
        }
    }
}
