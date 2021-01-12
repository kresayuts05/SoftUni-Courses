using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> emojiesDic = new Dictionary<string, int>();

            string emojisPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            Regex emojies = new Regex(emojisPattern);
            string numbersPattern = @"\d";
            Regex numbers = new Regex(numbersPattern);

            long threshold = 1;
            foreach (char number in input)
            {
                if (numbers.Match(number.ToString()).Success)
                {
                    threshold *= int.Parse(number.ToString());
                }
            }

            foreach (Match match in emojies.Matches(input))
            {
                if (match.Success)
                {
                    int coolness = 0;
                    foreach (var item in match.ToString())
                    {
                        coolness += item;
                    }
                    emojiesDic.Add(match.ToString(), coolness);
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiesDic.Count} emojis found in the text. The cool ones are:");

            foreach (var emojie in emojiesDic)
            {
                if (emojie.Value > threshold)
                {
                    Console.WriteLine(emojie.Key);
                }
            }
        }
    }
}
