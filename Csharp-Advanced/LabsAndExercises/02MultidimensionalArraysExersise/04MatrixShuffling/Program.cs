    using System;
    using System.Linq;

    namespace _04MatrixShuffling
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

                string[,] matrix = new string[rows, cols];

                for (int row = 0; row < rows; row++)
                {
                    string[] arr = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = arr[col];
                    }
                }

                string token = Console.ReadLine();

                while (token != "END")
                {
                    string[] command = token
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (command.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                        token = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (command[0] != "swap")
                        {
                            Console.WriteLine("Invalid input!");
                            token = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            bool validRow = true;
                            bool validCol = true;

                            for (int i = 1; i < command.Length; i += 2)
                            {
                                if (int.Parse(command[i]) >= rows || int.Parse(command[i]) < 0)
                                {
                                    validRow = false;
                                }
                            }
                            for (int i = 2; i < command.Length; i += 2)
                            {
                                if (int.Parse(command[i]) >= cols || int.Parse(command[i]) < 0)
                                {
                                    validCol = false;
                                }
                            }

                            if(validRow == false || validCol == false)
                            {
                                Console.WriteLine("Invalid input!");
                                token = Console.ReadLine();
                                continue;
                            }
                        }

                        string cellOne = matrix[int.Parse(command[1]), int.Parse(command[2])];
                        string cellTwo = matrix[int.Parse(command[3]), int.Parse(command[4])];

                        string cellSaving = cellOne;
                        matrix[int.Parse(command[1]), int.Parse(command[2])] = cellTwo;
                        matrix[int.Parse(command[3]), int.Parse(command[4])] = cellOne;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + ' ');
                            }
                            Console.WriteLine();
                        }
                    }
                    token = Console.ReadLine();
                }
            }
        }
    }
