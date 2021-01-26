using System;
using System.Linq;

namespace _06JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = new int[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = row; i <= row + 1; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] *= 2;
                        }
                    }
                }
                else
                {
                    for (int i = row; i <= row + 1; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] /= 2;
                        }
                    }
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < n && row > -1 && col < jagged[row].Length && col > -1)
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
