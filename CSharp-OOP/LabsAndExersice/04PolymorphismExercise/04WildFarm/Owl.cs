using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eating(string foodType, int quantity)
        {
            if (foodType == nameof(Meat))
            {
                FoodEaten += quantity;
                Weight += 0.25 * quantity;

                return;
            }

            this.ThrowExeption(foodType);
        }
    }
}
