using System;
using System.Collections.Generic;
using System.Text;

namespace _07MilitaryElite
{
    public class Private : IPrivate
    {
        public int ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public decimal Salary { get; private set; }
    }
}
