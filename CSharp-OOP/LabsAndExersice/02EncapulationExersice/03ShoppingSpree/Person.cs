using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03ShoppingSpree
{
    public class Person
    {
        private List<Product> bag;
        private string name;
        private int money;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;

            bag = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public int Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Bag { get => bag; }

        public string CanAffordProduct(Product product)
        {
            if (Money - product.Cost >= 0)
            {
                Bag.Add(product);
                Money -= product.Cost;

                return $"{Name} bought {product.Name}";
            }

            return $"{Name} can't afford {product.Name}";
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(Name + " - ");

            if (!Bag.Any())
            {
                output.Append("Nothing bought");
            }
            else
            {
                List<string> productsNames = new List<string>();

                foreach (var item in Bag)
                {
                    productsNames.Add(item.Name);
                }

                output.Append(string.Join(", ", productsNames));
            }
            return output.ToString().Trim();
        }
    }
}
