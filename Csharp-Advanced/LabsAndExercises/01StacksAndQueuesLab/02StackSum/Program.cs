using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);

            string token = Console.ReadLine().ToLower();
            while (token != "end")
            {
                string[] command = token
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command[0] == "remove")
                {
                    int number = int.Parse(command[1]);

                    if (number < stack.Count)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                token = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
