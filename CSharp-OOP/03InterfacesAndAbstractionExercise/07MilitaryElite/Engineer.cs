using System;
using System.Collections.Generic;
using System.Text;

namespace _07MilitaryElite
{
    public class Engineer : ISpecialisedSoldier
    {
        public string Crop { get; private set; }

        public int ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public List<Repair> Repairs { get; private set; }


    }
}
