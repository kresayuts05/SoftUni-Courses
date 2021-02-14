using System;
using System.Linq;

namespace _05SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            int rows = inputNumbers[0];
            int cols = inputNumbers[1];

            char[,] matrix = new char[rows, cols];

            char[] snake = Console.ReadLine()
                .ToCharArray();

            int snakeCount = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (snakeCount == snake.Length)
                        {
                            snakeCount = 0;
                            matrix[row, col] = snake[snakeCount];
                            snakeCount++;
                        }
                        else
                        {
                            matrix[row, col] = snake[snakeCount];
                            snakeCount++;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (snakeCount == snake.Length)
                        {
                            snakeCount = 0;
                            matrix[row, col] = snake[snakeCount];
                            snakeCount++;
                        }
                        else
                        {
                            matrix[row, col] = snake[snakeCount];
                            snakeCount++;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
