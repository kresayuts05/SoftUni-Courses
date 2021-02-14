using System;
using System.Collections.Generic;

namespace _06GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                Box<double> element = new Box<double>(input);
                boxes.Add(element);
            }

            double valueForCompationString = double.Parse(Console.ReadLine());
            Box<double> valueForCompation = new Box<double>(valueForCompationString);

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
