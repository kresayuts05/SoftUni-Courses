using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliter = 50;
        private const decimal CoffeePrice = 3.5M;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliter)
        {
            Caffeine = caffeine;
        }

        public double Caffeine  { get; set; }
    }
}
