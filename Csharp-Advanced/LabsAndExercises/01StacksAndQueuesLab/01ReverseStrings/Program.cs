using System;
using System.Collections.Generic;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var letter in input)
            {
                stack.Push(letter);
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop()); 
            }
        }
    }
}
