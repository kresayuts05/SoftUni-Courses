using System;
using System.Collections.Generic;
using System.Text;

namespace _04PizzaCalories
{
    public class Pizza
    {
        private List<Topping> toppings;
        private double totalCalories;
        private string name;
        private int numberOfToppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;

            toppings = new List<Topping>();
        }

        public  Dough Dough{ get; set; }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public int NumberOfToppings
        {
            get => numberOfToppings;
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                numberOfToppings = value;
            }
        }

        public double TotalCalories
        {
            get => totalCalories;
            private set
            {
                totalCalories = value;
            }
        }


        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
            NumberOfToppings++;
        }

        //private double CalculateCalories()
        //{
        //    double toppingsCalories = 0;
        //    foreach (var toping in toppings)
        //    {
        //        toppingsCalories += toping.Calories;
        //    }

        //    TotalCalories = toppingsCalories + Dough.Calories;

        //    return TotalCalories;
        //}

        public override string ToString()
        {
            double toppingsCalories = 0;
            foreach (var toping in toppings)
            {
                toppingsCalories += toping.Calories;
            }

            TotalCalories = toppingsCalories + Dough.Calories;

            return $"{Name} - {TotalCalories:F2} Calories.";
        }
    }
}
