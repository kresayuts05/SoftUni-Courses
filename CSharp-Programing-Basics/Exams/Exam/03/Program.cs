using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            string sex = Console.ReadLine();

            int peopleYears = 0;
            if (breed == "British Shorthair" && sex == "m")
            {
                peopleYears = 13;
            }
            else if (breed == "British Shorthair" && sex == "f")
            {
                peopleYears = 14;
            }
            else if (breed == "Siamese" && sex == "m")
            {
                peopleYears = 15;
            }
            else if (breed == "Siamese" && sex == "f")
            {
                peopleYears = 16;
            }
            else if (breed == "Persian" && sex == "m")
            {
                peopleYears = 14;
            }
            else if (breed == "Persian" && sex == "f")
            {
                peopleYears = 15;
            }
            else if (breed == "Ragdoll" && sex == "m")
            {
                peopleYears = 16;
            }
            else if (breed == "Ragdoll" && sex == "f")
            {
                peopleYears = 17;
            }
            else if (breed == "American Shorthair" && sex == "m")
            {
                peopleYears = 12;
            }
            else if (breed == "American Shorthair" && sex == "f")
            {
                peopleYears = 13;
            }
            else if (breed == "Siberian" && sex == "m")
            {
                peopleYears = 11;
            }
            else if (breed == "Siberian" && sex == "f")
            {
                peopleYears = 12;
            }
            else
            {
                Console.WriteLine($"{breed} is invalid cat!");
                breed = "invalid";
            }

            int catMonths = (peopleYears * 12) / 6;
            if (breed != "invalid")
            {
                Console.WriteLine($"{catMonths} cat months");
            }
        }
    }
}
