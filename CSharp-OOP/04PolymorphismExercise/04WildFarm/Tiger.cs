using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eating(string foodType, int quantity)
        {
            if (foodType == nameof(Meat))
            {
                FoodEaten += quantity;
                Weight +=  1 * quantity;

                return;
            }

            this.ThrowExeption(foodType);
        }
    }
}
