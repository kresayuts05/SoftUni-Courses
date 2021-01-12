using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Translate":
                        char oldValue = char.Parse(tokens[1]);
                        char replacement = char.Parse(tokens[2]);

                        input = input.Replace(oldValue, replacement);

                        break;
                    case "Includes":
                        string contains = tokens[1];

                        if (input.Contains(contains))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        contains = tokens[1];

                        if (input.Substring(0, contains.Length) == contains)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        break;
                    case "Remove":
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
