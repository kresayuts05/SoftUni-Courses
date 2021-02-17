using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isFinished = false;

            while (commandsCount != 0)
            {
                string command = Console.ReadLine();

                matrix[playerRow, playerCol] = '-';

                int previousRow = playerRow;
                int previousCol = playerCol;

                playerRow = MoveRow(playerRow, command);
                playerCol = MoveCol(playerCol, command);

                int[] positions = IsPositionValid(playerRow, playerCol, n, n);

                playerRow = positions[0];
                playerCol = positions[1];

                if (matrix[playerRow, playerCol] == 'B')//|| matrix[playerRow, playerCol] == 'b')
                {
                    playerRow = MoveRow(playerRow, command);
                    playerCol = MoveCol(playerCol, command);

                    positions = IsPositionValid(playerRow, playerCol, n, n);

                    playerRow = positions[0];
                    playerCol = positions[1];

                }
                else if (matrix[playerRow, playerCol] == 'T')//|| matrix[playerRow, playerCol] == 't')
                {
                    playerRow = previousRow;
                    playerCol = previousCol;

                    matrix[playerRow, playerCol] = 'f';
                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    isFinished = true;
                    break;
                }

                matrix[playerRow, playerCol] = 'f';

                commandsCount--;
            }


            if (isFinished)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

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

        public static int[] IsPositionValid(int row, int col, int rows, int cols)
        {
            int[] tokens = new int[] { row, col };
            if (row >= rows)
            {
                tokens[0] = 0;
                return tokens;
            }
            if (row < 0)
            {
                tokens[0] = rows - 1;
                return tokens;
            }

            if (col >= cols)
            {
                tokens[1] = 0;
                return tokens;
            }
            if (col < 0)
            {
                tokens[1] = cols - 1;
                return tokens;
            }

            return tokens;
        }
    }
}
