using System;
using System.Collections.Generic;

namespace _03ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '=', ';' };

            try
            {
                string[] people = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, Person> dictionaryPeople = new Dictionary<string, Person>();
                for (int i = 0; i < people.Length; i += 2)
                {
                    Person person = new Person(people[i], int.Parse(people[i + 1]));

                    dictionaryPeople.Add(person.Name, person);
                }

                string[] products = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, Product> dictionaryProducts = new Dictionary<string, Product>();
                for (int i = 0; i < products.Length; i += 2)
                {
                    Product product = new Product(products[i], int.Parse(products[i + 1]));

                    dictionaryProducts.Add(product.Name, product);
                }

                string commandInput = Console.ReadLine();

                while (commandInput.ToLower() != "end")
                {
                    string[] command = commandInput.Split();

                    Console.WriteLine(dictionaryPeople[command[0]].CanAffordProduct(dictionaryProducts[command[1]]));

                    commandInput = Console.ReadLine();
                }

                foreach (var item in dictionaryPeople.Values)
                {
                    Console.WriteLine(item); ;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
