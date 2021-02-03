using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            : this()
        {
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public string Name { get; set; }

        public int Age { get; set; }

        public List<Person> Members { get; set; }


        //public Person[] Filter(Person[] people)
        //{
        //    Person[] members = people
        //        .Where(p => p.Age > 30)
        //        .OrderBy(p => p.Name)
        //        .ToArray();

        //    return members;
            
        //}
    }
}
