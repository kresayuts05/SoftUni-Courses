using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public class InsideTable : Table
    {
        private const decimal pricePerPerson = 2.5M;

        public InsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, pricePerPerson)
        {
        }
    }
}
