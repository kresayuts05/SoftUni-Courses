using System;
using System.Linq;

namespace _02Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] separators = new char[] { ',', ' ' };
            int[] commands = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[n, n];

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;

            for (int row = 0; row < n; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ");
                char[] charArray = new char[n];

                int index = 0;
                foreach (var item in currentRow)
                {
                    charArray[index] = char.Parse(currentRow[index]);
                    index++;
                }
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = charArray[col];

                    if (matrix[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            int firstPlayer = 0;
            int secondPlayer = 0;

            for (int i = 0; i < commands.Length; i += 2)
            {
                int currRow = commands[i];
                int currCol = commands[i + 1];

                if (IsPositionValid(currRow, currCol, n, n))
                {
                    switch (matrix[currRow, currCol])
                    {
                        case '*':
                        break;

                        case '<':
                            secondPlayer++;
                            firstPlayerShips--;
                            matrix[currRow, currCol] = 'X';
                            break;

                        case '>':
                            firstPlayer++;
                            secondPlayerShips--;
                            matrix[currRow, currCol] = 'X';
                            break;

                        case '#':
                            int row = currRow;
                            int col = currCol;

                            matrix[row, col] = 'X';

                            if (IsPositionValid(row - 1, col - 1, n, n))
                            {

                                if (matrix[row - 1, col - 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row - 1, col - 1] = 'X';
                                }
                                else if (matrix[row - 1, col - 1] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row - 1, col - 1] = 'X';
                                }
                            }

                            if (IsPositionValid(row - 1, col, n, n))
                            {
                                if (matrix[row - 1, col] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row - 1, col] = 'X';
                                }
                                else if (matrix[row - 1, col] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row - 1, col] = 'X';
                                }
                            }

                            if (IsPositionValid(row - 1, col + 1, n, n))
                            {
                                if (matrix[row - 1, col + 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row - 1, col + 1] = 'X';
                                }
                                else if (matrix[row - 1, col + 1] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row - 1, col + 1] = 'X';
                                }
                            }
                            // up

                            if (IsPositionValid(row, col - 1, n, n))
                            {
                                if (matrix[row, col - 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row, col - 1] = 'X';
                                }
                                else if (matrix[row, col - 1] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row, col - 1] = 'X';
                                }
                            }

                            if (IsPositionValid(row, col + 1, n, n))
                            {
                                if (matrix[row, col + 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row, col + 1] = 'X';
                                }
                                else if (matrix[row, col + 1] == '<')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row, col + 1] = 'X';
                                }
                            }
                            // middle

                            if (IsPositionValid(row + 1, col - 1, n, n))
                            {
                                if (matrix[row + 1, col - 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row + 1, col - 1] = 'X';
                                }
                                else if (matrix[row + 1, col - 1] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row + 1, col - 1] = 'X';
                                }
                            }

                            if (IsPositionValid(row + 1, col, n, n))
                            {
                                if (matrix[row + 1, col] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row + 1, col] = 'X';
                                }
                                else if (matrix[row + 1, col] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row + 1, col] = 'X';
                                }
                            }

                            if (IsPositionValid(row + 1, col + 1, n, n))
                            {
                                if (matrix[row + 1, col + 1] == '<')
                                {
                                    secondPlayer++;
                                    firstPlayerShips--;
                                    matrix[row + 1, col + 1] = 'X';
                                }
                                else if (matrix[row + 1, col + 1] == '>')
                                {
                                    firstPlayer++;
                                    secondPlayerShips--;
                                    matrix[row + 1, col + 1] = 'X';
                                }
                            }

                            break;

                        default:
                            break;
                    }

                    if (secondPlayerShips <= 0)
                    {
                        Console.WriteLine($"Player One has won the game! {firstPlayer + secondPlayer} ships have been sunk in the battle.");
                        return;
                    }
                    else if (firstPlayerShips <= 0)
                    {
                        Console.WriteLine($"Player Two has won the game! {secondPlayer + firstPlayer} ships have been sunk in the battle.");
                        return;
                    }
                }
            }

            Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
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
