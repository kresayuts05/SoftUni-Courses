using System;
using System.Collections.Generic;

namespace _05GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Box<string> element = new Box<string>(input);
                boxes.Add(element);
            }

            string valueForCompationString = Console.ReadLine();
            Box<string> valueForCompation = new Box<string>(valueForCompationString);

            int output = GreaterCount(boxes, valueForCompation);
            Console.WriteLine(output);
        }

        private static int GreaterCount<T>(List<Box<T>> boxes, Box<T> value)
            where T : IComparable
        {
            int count = 0;
            foreach (Box<T> box in boxes)
            {
                if (box.Value.CompareTo(value.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
