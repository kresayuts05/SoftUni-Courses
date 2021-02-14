using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, List<int>> listOfDevisibles = ListOfDevisibles;

            Console.WriteLine(string.Join(" ", listOfDevisibles(dividers, n)));
        }

        static List<int> ListOfDevisibles(int[] dividers, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= endNum; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < dividers.Length; i++)
            {
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    if (list[j] % dividers[i] != 0)
                    {
                        list.Remove(list[j]);
                    }
                }
            }

            return list;
        }
    }
}
