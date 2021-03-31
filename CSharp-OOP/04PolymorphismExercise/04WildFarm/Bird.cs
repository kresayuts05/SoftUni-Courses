using System;
using System.Collections.Generic;
using System.Text;

namespace _04WildFarm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        public  double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Math.Round(Weight, 2)}, {FoodEaten}]";
        }
    }
}
