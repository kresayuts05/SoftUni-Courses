using System;
using System.Linq;

namespace _05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Action<string, int[]> action = Printer;

            while(command.ToUpper() != "END")
            {
                action(command, array);

                command = Console.ReadLine();
            }
        }

        static void Printer(string command, int[] array)
        {
            switch(command)
            {
                case "add":
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] += 1;
                    }
                    break;

                case "multiply":
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] *= 2;
                    }
                    break;

                case "subtract":
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                    break;

                case "print":
                    Console.WriteLine(string.Join(" ", array));
                    break;

                default:
                    break;
            }
        }
    }
}
