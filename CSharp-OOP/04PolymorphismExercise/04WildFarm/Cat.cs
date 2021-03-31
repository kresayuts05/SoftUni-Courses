using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
               : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Eating(string foodType, int quantity)
        {
            if (foodType == nameof(Vegetable) || foodType == nameof(Meat))
            {
                FoodEaten += quantity;
                Weight += 0.30 * quantity;

                return;
            }

            this.ThrowExeption(foodType);
        }
    }
}
