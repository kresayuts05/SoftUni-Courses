using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> clients = new Dictionary<string, List<string>>();

            int countUnlikedMeals = 0;

            string command = Console.ReadLine();

            while (command.ToLower() != "stop")
            {
                string[] tokens = command
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string commandType = tokens[0].ToLower();
                string guest = tokens[1];
                string meal = tokens[2];

                if (commandType == "like")
                {
                    if (!clients.ContainsKey(guest))
                    {
                        clients.Add(guest, new List<string>());
                    }

                    if (!clients[guest].Contains(meal))
                    {
                        clients[guest].Add(meal);
                    }
                }
                else
                {
                    if (!clients.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        continue;
                    }

                    if (!clients[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        continue;
                    }

                    clients[guest].Remove(meal);
                    Console.WriteLine($"{guest} doesn't like the {meal}.");
                    countUnlikedMeals++;
                }

                command = Console.ReadLine();
            }

            foreach (var client in clients.OrderByDescending(x => x.Value.Count).ThenBy(c => c))
            {
                Console.Write($"{client.Key}: ");
                Console.Write(string.Join(", ", client.Value));
                Console.WriteLine();
            }

            Console.WriteLine($"Unliked meals: {countUnlikedMeals}");
        }
    }
}
