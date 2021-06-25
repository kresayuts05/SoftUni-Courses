using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eating(string foodType, int quantity)
        {
            if (foodType == nameof(Meat))
            {
                FoodEaten += quantity;
                Weight += 0.40 * quantity;

                return;
            }

            this.ThrowExeption(foodType);
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Math.Round(Weight, 2)}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
