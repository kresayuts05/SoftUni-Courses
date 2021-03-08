using System;
using System.Collections.Generic;
using System.Text;

namespace _04PizzaCalories
{
    public class Dough
    {
        private const double white = 1.5;
        private const double wholegrain = 1;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1;

        private double type;
        private double technique;
        private double weight;
        private double calories;

        public Dough(string typeInput, string techniqueInput, double grams)
        {
            if (typeInput.ToLower() == "white")
            {
                type = white;
            }
            else if (typeInput.ToLower() == "wholegrain")
            {
                type = wholegrain;
            }

            if (techniqueInput.ToLower() == "crispy")
            {
                technique = crispy;
            }
            else if (techniqueInput.ToLower() == "chewy")
            {
                technique = chewy;
            }
            else if (techniqueInput.ToLower() == "homemade")
            {
                technique = homemade;
            }

            Weight = grams;

            Calories = (2 * Weight) * Technique * Type;
        }


        public double Type
        {
            get => type;
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                type = value;
            }
        }

        public double Technique
        {
            get => technique;
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                technique = value;
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if(value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }

        public double Calories 
        { 
            get => calories;
            private set
            {
                calories = value;
            }
        }
    }
}
