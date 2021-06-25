﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04BorderControl
{
    public class Citizen : IPerson
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public int BuyFood()
        {
            Food += 10;

            return 10;
        }
    }
}
