using System;
using System.Collections.Generic;

namespace _05CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!dictionary.ContainsKey(symbol))
                {
                    dictionary.Add(symbol, 0);
                }

                dictionary[symbol]++;
            }

            foreach (var symbol in dictionary)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
