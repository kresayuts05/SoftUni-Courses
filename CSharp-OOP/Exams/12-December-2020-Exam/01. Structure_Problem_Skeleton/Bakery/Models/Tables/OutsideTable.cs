using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public class OutsideTable : Table
    {
        private const decimal pricePerPerson = 3.5M;

        public OutsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, pricePerPerson)
        {
        }
    }
}
