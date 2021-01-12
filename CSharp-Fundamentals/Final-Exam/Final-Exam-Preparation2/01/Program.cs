using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine()
                .Split(">>>", StringSplitOptions.RemoveEmptyEntries);


            while (command[0] != "Generate")
            {
                string commandType = command[0];
                int startIndex = 0;
                int endIndex = 0;

                if (commandType == "Contains")
                {
                    string substring = command[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandType == "Flip")
                {
                    string flipType = command[1];
                    startIndex = int.Parse(command[2]);
                    endIndex = int.Parse(command[3]);

                    string oldValue = string.Empty;
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        oldValue += input[i];
                    }

                    if (flipType == "Upper")
                    {
                        input = input.Replace(oldValue, oldValue.ToUpper());
                    }
                    else
                    {
                        input = input.Replace(oldValue, oldValue.ToLower());
                    }
                    Console.WriteLine(input);
                }
                else if (commandType == "Slice")
                {
                    startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);

                    string oldValue = string.Empty;
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        oldValue += input[i];
                    }

                    input = input.Replace(oldValue, "");
                    Console.WriteLine(input);
                }

                command = Console.ReadLine()
                .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
