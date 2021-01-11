using System;

namespace _01GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            if (b == 0)
            {
                result = a;
            }
            else
            {
                while (b != 0)
                {
                    result = b;
                    b = a % b;
                    a = result;
                }
            }
            Console.WriteLine(result);
        }
    }
}
