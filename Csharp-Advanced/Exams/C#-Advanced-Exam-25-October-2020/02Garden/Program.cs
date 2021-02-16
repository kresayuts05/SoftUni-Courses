using System;
using System.Linq;

namespace _02Garden
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            string command = Console.ReadLine();
            while (command.ToLower() != "bloom bloom plow")
            {
                int[] position = command.Split().Select(int.Parse).ToArray();
                int flowerRow = position[0];
                int flowerCol = position[1];
                if (!IsOut(flowerRow, flowerCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    //row blooming
                    for (int row = flowerRow; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, flowerCol] += 1;
                    }
                    for (int row = flowerRow - 1; row >= 0; row--)
                    {
                        matrix[row, flowerCol] += 1;
                    }
                    //col blooming
                    for (int col = flowerCol + 1; col < matrix.GetLength(1); col++)
                    {
                        matrix[flowerRow, col] += 1;
                    }
                    for (int col = flowerCol - 1; col >= 0; col--)
                    {
                        matrix[flowerRow, col] += 1;
                    }
                }
                command = Console.ReadLine();
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        public static bool IsOut(int flowerRow, int flowerCol, int matrixRows, int matrixCols)
        {
            if (flowerRow >= matrixRows || flowerRow < 0)
            {
                return false;
            }
            if (flowerCol >= matrixCols || flowerCol < 0)
            {
                return false;
            }
            return true;
        }
    }
}
