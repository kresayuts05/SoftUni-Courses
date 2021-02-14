using System;

namespace _02GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                Box<int> element = new Box<int>(value);

                Console.WriteLine(element);
            }
        }
    }
}
