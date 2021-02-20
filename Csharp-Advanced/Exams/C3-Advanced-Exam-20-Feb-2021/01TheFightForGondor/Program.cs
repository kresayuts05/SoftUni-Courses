using System;
using System.Collections.Generic;
using System.Linq;

namespace _01TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] platesInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> plates = new Stack<int>(platesInput.Reverse());
            Stack<int> warriors = new Stack<int>();

            int warriorOst = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!plates.Any())
                {
                    break;
                }

                int[] warriorsInput = Console.ReadLine()
                    .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

                warriors = new Stack<int>(warriorsInput);

                if (warriorOst > 0)
                {
                    warriors.Push(warriorOst);
                }

                if (i % 3 == 0)
                {
                    int addPlate = int.Parse(Console.ReadLine());
                    plates.Reverse();
                    plates.Push(addPlate);
                    plates.Reverse();
                }

                while (plates.Any() && warriors.Any())
                {
                    int plate = plates.Pop();
                    int warrior = warriors.Pop();

                    if (plate - warrior > 0)
                    {
                        plate -= warrior;
                        plates.Push(plate);
                    }
                    else if (plate - warrior < 0)
                    {
                        warrior -= plate;
                        warriors.Push(warrior);
                    }

                    if (!plates.Any() && warriors.Any())
                    {
                        warrior -= plate;
                        warriorOst = warrior;
                    }

                }

            }

            if (!plates.Any())
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (warriors.Any())
            {
                Console.WriteLine("Orcs left: " + string.Join(", ", warriors));
            }

            if (plates.Any())
            {
                Console.WriteLine("Plates left: " + string.Join(", ", plates));
            }
        }
    }
}
