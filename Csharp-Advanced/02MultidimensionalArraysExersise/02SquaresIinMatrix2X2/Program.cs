using System;
using System.Linq;

namespace _02SquaresIinMatrix2X2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int r = inputNumbers[0];
            int c = inputNumbers[1];

            char[,] matrix = new char[r, c];

            for (int row = 0; row < r; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int count = 0;
            for (int row = 0; row < r - 1; row++)
            {
                for (int col = 0; col < c - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1]
                        && matrix[row , col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
