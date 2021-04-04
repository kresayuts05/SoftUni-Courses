using System;
using System.Collections.Generic;

namespace _04WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] parameters = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal animal = CreateNewAnimal(parameters);
                list.Add(animal);
                animal.AskingFood();

                string[] foodInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodInput[0];
                int foodQuantity = int.Parse(foodInput[1]);

                try
                {
                    Food food = CreateNewFood(foodType, foodQuantity);
                    animal.Eating(food.GetType().Name, food.Quantity);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                command = Console.ReadLine();
            }

            foreach (var animal in list)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateNewFood(string foodType, int foodQuantity)
        {
            Food food = null;

            if (foodType == nameof(Fruit))
            {
                food = new Fruit(foodQuantity);
            }
            else if (foodType == nameof(Vegetable))
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == nameof(Meat))
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == nameof(Seeds))
            {
                food = new Seeds(foodQuantity);
            }

            return food;
        }

        private static Animal CreateNewAnimal(string[] parameters)
        {
            Animal animal = null;

            string type = parameters[0];
            string name = parameters[1];
            double weight = double.Parse(parameters[2]);

            if (type == nameof(Cat))
            {
                string livingRegion = parameters[3];
                string breed = parameters[4];

                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Tiger))
            {
                string livingRegion = parameters[3];
                string breed = parameters[4];

                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(parameters[3]);

                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Hen))
            {
                double wingSize = double.Parse(parameters[3]);

                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Mouse))
            {
                string livingRegion = parameters[3];

                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == nameof(Dog))
            {
                string livingRegion = parameters[3];

                animal = new Dog(name, weight, livingRegion);
            }

            return animal;
        }


    }
}
