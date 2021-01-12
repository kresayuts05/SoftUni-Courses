using System;

namespace _03SubString
{
    class Program
    {
        static void Main(string[] args)
        {

            string textToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(textToRemove))
            {
                text = text.Replace(textToRemove, string.Empty);
            }

            Console.WriteLine(text);
        }
    }
}
