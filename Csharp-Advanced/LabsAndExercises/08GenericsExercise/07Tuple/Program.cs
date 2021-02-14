using System;

namespace _07Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split(" ");
            string fullName = input1[0] + " " + input1[1];
            MyTuple<string, string> generic1 = new MyTuple<string, string>(fullName, input1[2]);

            string[] input2 = Console.ReadLine()
                .Split(" ");
            MyTuple<string, int> generic2 = new MyTuple<string, int>(input2[0], int.Parse(input2[1]));


            string[] input3 = Console.ReadLine()
                .Split(" ");
            MyTuple<int, double> generic3 = new MyTuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

            Console.WriteLine(generic1);
            Console.WriteLine(generic2);
            Console.WriteLine(generic3);
        }
    }
}
