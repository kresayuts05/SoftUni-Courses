using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidsInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] ingredientsInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> ingredients = new Stack<int>(ingredientsInput);

            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPipe = 0;

            while (liquids.Any() && ingredients.Any())
            {
                int liquid = liquids.Dequeue();
                int ingredient = ingredients.Pop();

                int sum = liquid + ingredient;

                switch (sum)
                {
                    case 25:
                        bread++;
                        break;

                    case 50:
                        cake++;
                        break;

                    case 75:
                        pastry++;
                        break;

                    case 100:
                        fruitPipe++;
                        break;

                    default:
                        ingredient += 3;
                        ingredients.Push(ingredient);
                        break;
                }
            }

            if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPipe >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Any())
            {
                Console.WriteLine("Liquids left: " + string.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Any())
            {
                Console.WriteLine("Ingredients left: " + string.Join(", ", ingredients));
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPipe}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
