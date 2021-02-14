using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> elements = new Stack<string>(input.Reverse());

            while (elements.Count > 1)
            {
                int firstNumber = int.Parse(elements.Pop());
                string sign = elements.Pop();
                int secondNumber = int.Parse(elements.Pop());

                int result = 0;
                if (sign == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else
                {
                    result = firstNumber + secondNumber;
                }

                elements.Push(result.ToString());
            }

            Console.WriteLine(elements.Pop());
        }
    }
}
