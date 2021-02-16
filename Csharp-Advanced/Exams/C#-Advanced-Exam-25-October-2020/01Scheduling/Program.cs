using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksInput = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[] threadsInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> tasks = new Stack<int>(tasksInput);
            Queue<int> threads = new Queue<int>(threadsInput);

            int killValue = int.Parse(Console.ReadLine());

            while(tasks.Peek() != killValue)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();

                if(thread >= task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {killValue}");

            Console.WriteLine(string.Join(" ", threads));
        }
    }   
}
