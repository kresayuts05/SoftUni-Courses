using System;
using System.Linq;

namespace _03MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int r = arr[0];
            int c = arr[1];

            int[,] matrix = new int[r, c];

            for (int row = 0; row < r; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < r - 2; row++)
            {
                for (int col = 0; col < c - 2; col++)
                {
                    int currSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            currSum += matrix[row + i, col + j];
                        }
                    }
                    if (currSum > sum)
                    {
                        sum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + sum);

            for (int row = maxRow; row < maxRow + 3; row++)
            {
                for (int col = maxCol; col < maxCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
