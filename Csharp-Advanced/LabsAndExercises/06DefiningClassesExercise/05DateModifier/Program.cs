using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDateStr = Console.ReadLine();
            string secondDateStr = Console.ReadLine();

            Console.WriteLine(DateModifier.DaysCalculator(firstDateStr, secondDateStr));
        }
    }
}
