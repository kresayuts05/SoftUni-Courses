using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>(input);

            while (queue.Any())
            {
                string text = command.Substring(0, 4);
                switch (text)
                {
                    case "Play":
                        queue.Dequeue();
                        break;

                    case "Add ":
                        string song = command.Substring(4);
                        if (!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                    default:
                        break;
                }

                if(queue.Count() == 0)
                {
                    Console.WriteLine("No more songs!");
                }

                command = Console.ReadLine();
            }
        }
    }
}