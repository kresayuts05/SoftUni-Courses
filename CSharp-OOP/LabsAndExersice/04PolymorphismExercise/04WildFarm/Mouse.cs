using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eating(string foodType, int quantity)
        {
            if (foodType == nameof(Vegetable) || foodType == nameof(Fruit))
            {
                FoodEaten += quantity;
                Weight += 0.1 * quantity;

                return;
            }

            this.ThrowExeption(foodType);
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight:f1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
