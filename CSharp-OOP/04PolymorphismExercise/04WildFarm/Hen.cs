using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public class Hen : Bird
    {
        public Hen (string name, double weight, double wingSize)
             : base(name, weight, wingSize)
        {
        }

        public override void AskingFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eating(string foodType, int quantity)
        {
            FoodEaten += quantity;
            Weight +=  0.35 * quantity;
        }
    }
}
