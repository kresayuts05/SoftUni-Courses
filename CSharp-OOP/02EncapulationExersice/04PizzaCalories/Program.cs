using System;

namespace _04PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string[] doughInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaInput[1], dough);

                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                while (command[0].ToLower() != "end")
                {
                    Topping topping = new Topping(command[1], double.Parse(command[2]));

                    pizza.AddTopping(topping);

                    command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
