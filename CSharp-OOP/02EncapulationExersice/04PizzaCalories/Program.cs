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
                .Split(" ");

                string[] doughInput = Console.ReadLine()
                    .Split(" ");

                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaInput[1], dough);

                string token = Console.ReadLine();

                while (token.ToLower() != "end")
                {
                    string[] command = token.Split();
                    Topping topping = new Topping(command[1], double.Parse(command[2]));

                    pizza.AddTopping(topping);

                    token = Console.ReadLine();
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
