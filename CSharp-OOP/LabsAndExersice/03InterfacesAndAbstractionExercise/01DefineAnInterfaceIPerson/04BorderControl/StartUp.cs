using System;
using System.Collections.Generic;
using System.Linq;

namespace _04BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> list = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    list.Add(name, new Citizen(name, age, id, birthdate));
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    list.Add(name, new Rebel(name, age, group));
                }
            }

            string command = Console.ReadLine();

            int total = 0;
            while (command.ToLower() != "end")
            {
                if (list.ContainsKey(command))
                {
                    total += list[command].BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(total);



            //List<IBirthable> indentifianles = new List<IBirthable>();

            //string inputStr = Console.ReadLine();

            //while (inputStr.ToLower() != "end")
            //{
            //    string[] input = inputStr.Split();

            //    if (input[0] == "Citizen")
            //    {
            //        string name = input[1];
            //        int age = int.Parse(input[2]);
            //        string id = input[3];
            //        string birthdate = input[4];

            //        indentifianles.Add(new Citizen(name, age, id, birthdate));
            //    }
            //    else if(input[0] == "Pet")
            //    {
            //        string name = input[1];
            //        string birthdate = input[2];

            //        indentifianles.Add(new Pet(name, birthdate));
            //    }

            //    inputStr = Console.ReadLine();
            //}

            //string year = Console.ReadLine();

            //List<IBirthable> filtred = indentifianles
            //    .Where(x => x.Birthdate.EndsWith(year))
            //    .ToList();

            //foreach (var item in filtred)
            //{
            //    Console.WriteLine(item.Birthdate);
            //}
        }
    }
}
