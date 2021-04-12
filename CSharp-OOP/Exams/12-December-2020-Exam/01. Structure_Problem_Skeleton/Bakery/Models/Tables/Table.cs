using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;
        private bool isReserved = false;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;

            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();
        }

        private List<IBakedFood> foodOrders;
        private List<IDrink> drinkOrders;

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }

                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }

                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get => isReserved; }

        public decimal Price { get => PricePerPerson * NumberOfPeople; }

        public void Clear()
        {
            foodOrders.Clear();
            drinkOrders.Clear();
            isReserved = false;
            numberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal bill = 0;

            foreach (var food in foodOrders)
            {
                bill += food.Price;
            }

            foreach (var drink in drinkOrders)
            {
                bill += drink.Price;
            }

            bill += Price;

            return bill;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {PricePerPerson:f2}");

            return sb.ToString().Trim();

        }

        public void OrderDrink(IDrink drink)
        {
            drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            isReserved = true;
            NumberOfPeople = numberOfPeople;
        }
    }
}
