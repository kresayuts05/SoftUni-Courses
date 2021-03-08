using System;
using System.Collections.Generic;
using System.Text;

namespace _04PizzaCalories
{
    public class Topping
    {
        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;

        private double type;
        private double weight;
        private double calories;
        private string name;

        public Topping(string typeInput, double grams)
        {
            name = typeInput;
            if (typeInput.ToLower() == "meat")
            {
                type = meat;
            }
            else if(typeInput.ToLower() == "veggies")
            {
                type = veggies;
            }
            else if (typeInput.ToLower() == "cheese")
            {
                type = cheese;
            }
            else if (typeInput.ToLower() == "sauce")
            {
                type = sauce;
            }

            weight = grams;
        }

        public double Type
        {
            get => type;
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException($"Cannot place {name} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{name} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double Calories
        {
            get => calories;
            private set
            {
                calories = (2 * Weight) * type;
            }
        }
    }
}
