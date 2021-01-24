using System;
using System.Collections.Generic;

namespace _04EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> elements = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!elements.ContainsKey(number))
                {
                    elements.Add(number, 0);
                }

                elements[number]++;
            }

            foreach (var element in elements)
            {
                if(element.Value % 2 == 0)
                {
                    Console.WriteLine(element.Key);
                    return;
                }
            }
        }
    }
}
