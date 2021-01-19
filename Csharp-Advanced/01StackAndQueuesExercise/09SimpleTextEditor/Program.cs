using System;
using System.Collections.Generic;
using System.Linq;

namespace _09SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = string.Empty;
            Stack<string> commands = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            string command = string.Empty;
            string append = string.Empty;
            string removed = string.Empty;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                string text = command[1].ToString();
                switch (text)
                {
                    case "1 ":
                        append = command.Substring(2);
                        token += append;
                        commands.Push(append);
                        commands.Push("1");
                        break;

                    case "2 ":
                        int count = int.Parse(command.Substring(2));

                        for (int j = 0; j < count; j++)
                        {
                            removed += token.Substring(token.Length - 1);
                            token.Remove(token.Length - 1);
                        }

                        commands.Push(removed);
                        commands.Push("2");
                        break;

                    case "3 ":
                        int index = int.Parse(command[2].ToString());
                        Console.WriteLine($"{token[index]}");
                        break;

                    case "4 ":
                        int typeCommand = int.Parse(commands.Pop());

                        if (typeCommand == 1)
                        {
                            append = commands.Pop();

                            for (int j = 0; j < append.Length; j++)
                            {
                                token.Remove(token.Length - 1);
                            }
                        }
                        else
                        {
                            removed = commands.Pop();
                            token += removed;
                        }
                        break;
                }
            }
        }
    }
}
