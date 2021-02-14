using System;
using System.Collections.Generic;

namespace _04MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketsIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = bracketsIndex.Pop();

                    string expression = input.Substring(startIndex, i - startIndex+1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
