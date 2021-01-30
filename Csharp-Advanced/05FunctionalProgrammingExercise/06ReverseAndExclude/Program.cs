using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> func = Exclude;

            for (int i = list.Count - 1 ; i >= 0; i--)
            {
                if(func(list[i], n))
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static bool Exclude(int num, int n)
        {
            if(num % n == 0)
            {
                return true;
            }

            return false;
        }
    }
}
