using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people[i] = person;
            }

            Person[] members = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToArray();

            foreach (var person in members)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
