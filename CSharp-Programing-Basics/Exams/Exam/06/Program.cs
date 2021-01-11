using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int companys = int.Parse(Console.ReadLine());

            double max = 0;
            double average = 0;
            int sum = 0;
            int peopleCounter = 0;
            int sumPeople = 0;
            string maxCompanyName = "";
            for (int i = 1; i <= companys; i++)
            {
                string companyName = Console.ReadLine();
                string people = Console.ReadLine();
                while (people != "Finish")
                {
                    sum += int.Parse(people);
                    people = Console.ReadLine();
                    sum += int.Parse(people);
                    peopleCounter++;
                }
                average = sum / peopleCounter;
                if (max < average)
                {
                    max = average;
                    maxCompanyName = companyName;
                }
                sumPeople += sum;
                Console.WriteLine($"{companyName}: {Math.Floor(average)} passengers.");
                average = 0;
                sum = 0;
            }
            Console.WriteLine($"{maxCompanyName} has most passengers per flight: {Math.Floor(max)}");
        }
    }
    }
}
