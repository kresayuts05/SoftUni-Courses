using System;
using System.Collections.Generic;
using System.Linq;

namespace _07HotPotatoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children); 

            while(queue.Count > 1)
            {
                int x = 1;
                while(x < n)
                {
                    string child = queue.Dequeue();
                    queue.Enqueue(child);
                    x++;
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
