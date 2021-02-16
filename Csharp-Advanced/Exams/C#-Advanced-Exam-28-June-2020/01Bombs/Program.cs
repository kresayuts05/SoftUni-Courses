using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] effectsInput = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[] casingInput = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> effects = new Queue<int>(effectsInput);
            Stack<int> casings = new Stack<int>(casingInput);

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            bool isReady = false;
            while (effects.Any() && casings.Any() && isReady == false)
            {
                int casing = casings.Peek();
                int effect = effects.Peek();
                int sum = casing + effect;

                if (sum == 40)
                {
                    daturaBombs++;
                }
                else if(sum == 60)
                {
                    cherryBombs++;
                }
                else if(sum == 120)
                {
                    smokeDecoyBombs++;
                }
                else
                {
                    while(true)
                    {
                        sum -= 5;


                        if (sum == 40)
                        {
                            daturaBombs++;
                            break;
                        }
                        else if (sum == 60)
                        {
                            cherryBombs++;
                            break;
                        }
                        else if (sum == 120)
                        {
                            smokeDecoyBombs++;
                            break;
                        }
                    }
                }

                casings.Pop();
                effects.Dequeue();

                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    isReady = true;
                }
            }

            if(daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if(effects.Any())
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", effects));
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if(casings.Any())
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", casings));
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
