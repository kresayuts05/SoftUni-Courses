using System;

namespace _08Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
               .Split(" ");
            string fullName = input1[0] + " " + input1[1];
            if (input1.Length > 4)
            {
                MyTuple<string, string, string> generic11 = new MyTuple<string, string, string>(fullName, input1[2], input1[3] + " " + input1[4]);
                Console.WriteLine(generic11);
            }
            else
            {
                MyTuple<string, string, string> generic1 = new MyTuple<string, string, string>(fullName, input1[2], input1[3]);
                Console.WriteLine(generic1);

            }

            string[] input2 = Console.ReadLine()
                .Split(" ");
            bool isDrunk = false;
            if (input2[2].ToLower() == "drunk")
            {
                isDrunk = true;
            }
            MyTuple<string, int, bool> generic2 = new MyTuple<string, int, bool>(input2[0], int.Parse(input2[1]), isDrunk);
            Console.WriteLine(generic2);


            string[] input3 = Console.ReadLine()
                .Split(" ");
            MyTuple<string, double, string> generic3 = new MyTuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

            
            Console.WriteLine(generic3);
        }
    }
}
