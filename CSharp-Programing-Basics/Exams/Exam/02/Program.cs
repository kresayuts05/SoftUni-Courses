using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeve = double.Parse(Console.ReadLine());
            double front = double.Parse(Console.ReadLine());
            string cloth = Console.ReadLine();
            string tie = Console.ReadLine();

            double size = (sleeve + front) * 2 + ((sleeve + front) * 2) * 0.1;
            size /= 100;
            double price = 0;
            if (cloth == "Linen")
            {
                price = size * 15;
            }
            else if (cloth == "Cotton")
            {
                price = size * 12;
            }
            else if (cloth == "Denim")
            {
                price = size * 20;
            }
            else if (cloth == "Twill")
            {
                price = size * 16;
            }
            else if (cloth == "Flannel")
            {
                price = size * 11;
            }

            price += 10;
            if (tie == "Yes")
            {
                price += price * 0.2;
            }

            Console.WriteLine($"The price of the shirt is: {price:f2}lv.");
        }
    }
}
