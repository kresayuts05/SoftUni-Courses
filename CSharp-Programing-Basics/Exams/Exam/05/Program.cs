using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sea = int.Parse(Console.ReadLine());
            int mountain = int.Parse(Console.ReadLine());

            int price = 0;
            while (sea >= 0 || mountain >= 0)
            {
                string tipe = Console.ReadLine();
                if (tipe == "sea")
                {
                    sea--;
                    if (sea < 0)
                    {
                        price += 0;
                    }
                    else
                    {
                        price += 680;
                    }
                }
                else if (tipe == "mountain")
                {
                    mountain--;
                    if (mountain < 0)
                    {
                        price += 0;
                    }
                    else
                    {
                        price += 499;
                    }
                }
                else if (tipe == "Stop")
                {
                    break;
                }

                if (sea <= 0 && mountain <= 0)
                {
                    break;
                }
            }

            if (sea <= 0 && mountain <= 0)
            {
                Console.WriteLine(" Good job! Everything is sold.");
            }

            Console.WriteLine($"Profit: {price} leva.");
        }
    }
}
