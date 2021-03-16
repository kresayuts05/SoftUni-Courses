using System;
using System.Collections.Generic;
using System.Text;

namespace _07MilitaryElite
{
    public class Spy : ISpy
    {
        public int ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Code { get; private set; }
    }
}
