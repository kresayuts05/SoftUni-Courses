using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public  class Family
    {
        List<Person> people = new List<Person>();


        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public void GetOldestMember(List<Person> people)
        {
            int maxAge = 0;
            foreach (var person in people)
            {
                if(maxAge < person.Age)
                {
                    maxAge = person.Age;
                }
            }
        }
    }
}
