using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int sRow = 0;
            int sCol = 0;
            List<int> oPosition = new List<int>();

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

                    if (matrix[row, col] == 'O')
                    {
                        oPosition.Add(row);
                        oPosition.Add(col);
                    }
                }
            }
            int money = 0;
            bool isLost = false;
            while (money < 50)
            {
                string command = Console.ReadLine();

                matrix[sRow, sCol] = '-';

                sRow = MoveRow(sRow, command);
                sCol = MoveCol(sCol, command);

                if (!IsPositionValid(sRow, sCol, n, n))
                {
                    isLost = true;
                    break;
                }

                if (matrix[sRow, sCol] == 'O')
                {
                    matrix[sRow, sCol] = '-';

                    sRow = oPosition[2];
                    sCol = oPosition[3];
                }

                if (Char.IsDigit(matrix[sRow, sCol]))
                {
                    money += int.Parse(matrix[sRow, sCol].ToString());
                }

                matrix[sRow, sCol] = 'S';
            }

            if (isLost)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
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

    }
}
