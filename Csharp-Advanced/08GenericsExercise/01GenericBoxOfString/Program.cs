using System;

namespace _01GenericBoxOfString
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                Box<string> element = new Box<string>(value);

                Console.WriteLine(element);
            }
        }
    }
}
    