﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Drinks
{
    public class Water : Drink
    {
        private const decimal price = 1.5M;

        public Water(string name, int portion, string brand)
            : base(name, portion, price, brand)
        {
        }
    }
}
