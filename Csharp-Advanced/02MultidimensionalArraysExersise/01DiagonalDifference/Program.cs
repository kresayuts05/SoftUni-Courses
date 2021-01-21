using System;
using System.Linq;

namespace _01DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                sumLeft += matrix[i, i];
            }

            int rowRight = 0;
            int colRight = n - 1;
            while (colRight >= 0)
            {
                sumRight += matrix[rowRight, colRight];
                rowRight++;
                colRight--;
            }

            Console.WriteLine(Math.Abs(sumLeft - sumRight));
        }
    }
}
