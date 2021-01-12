using System;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^(\$|%){1}([A-Z][a-z]{2,})\1:\s(\[[0-9]+\])\|(\[[0-9]+\])\|(\[[0-9]+\])\|\s*$";
            Regex regex = new Regex(pattern);

            string numbersPattern = @"\d+";
            Regex numbersregex = new Regex(numbersPattern);


            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                if (regex.IsMatch(text))
                {
                    MatchCollection numbersMatches = numbersregex.Matches(text);

                    string decryptText = string.Empty;

                    foreach (Match number in numbersMatches)
                    {
                        int num = int.Parse(number.Value);
                        decryptText += (char)num;
                    }

                    string[] name = text
                        .Split(new[] { '$', '%' }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"{name[0]}: {decryptText}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
