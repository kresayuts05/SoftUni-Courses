using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double bed = double.Parse(Console.ReadLine());
            double toilet = double.Parse(Console.ReadLine());

            double food = toilet + toilet * 0.25;
            double toys = food / 2;
            double vet = toys + toys * 0.1;
            double month = toilet + food + toys + vet;
            double extra = month * 0.05;
            month += extra;
            double year = month * 12 + bed;
            Console.WriteLine($"{year:f2} lv.");
        }
    }
}
