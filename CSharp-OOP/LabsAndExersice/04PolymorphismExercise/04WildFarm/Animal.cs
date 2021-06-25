using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public abstract class Animal
    {
        private const int foodEaten = 0;

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract void AskingFood();

        public abstract void Eating(string foodType, int quantity);

        protected void ThrowExeption(string food)
        {
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
