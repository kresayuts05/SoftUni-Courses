using System;
using System.Collections.Generic;

namespace _02Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sRow = 0;
            int sCol = 0;
            List<int> b = new List<int>();

            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        sRow = row;
                        sCol = col;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        b.Add(row);
                        b.Add(col);
                    }
                }
            }

            int foodQuantity = 0;

            string input = Console.ReadLine();
            while (foodQuantity < 10)
            {
                matrix[sRow, sCol] = '.';

                sRow = MoveRow(sRow, input);
                sCol = MoveCol(sCol, input);

                if (!IsPositionValid(sRow, sCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[sRow, sCol] == '*')
                {
                    foodQuantity++;
                    matrix[sRow, sCol] = 'S';
                }

                if (matrix[sRow, sCol] == 'B')
                {
                    matrix[sRow, sCol] = '.';

                    if (sRow == b[0])
                    {
                        sRow = b[2];
                        sCol = b[3];
                    }

                    matrix[sRow, sCol] = 'S';
                }

                input = Console.ReadLine();
            }

            if (foodQuantity == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
    }
}
