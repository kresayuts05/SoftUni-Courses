using System;
using System.Collections.Generic;
using System.Linq;

namespace _08BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

                foreach (char item in input)
                {
                    if (item == '(' || item == '{' || item == '[')
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (item == ')' && stack.Peek() == '('
                            || item == '}' && stack.Peek() == '{'
                            || item == ']' && stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }

            Console.WriteLine("YES");
        }
    }
}
