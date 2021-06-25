using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Math.Round(Weight, 2)}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
