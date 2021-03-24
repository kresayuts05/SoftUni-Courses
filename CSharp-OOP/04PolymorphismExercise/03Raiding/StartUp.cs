using System;
using System.Collections.Generic;

namespace _03Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> list = new List<BaseHero>();

            while (list.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero = CreateNewHero(name, type);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                list.Add(hero);
            }

            int vilian = int.Parse(Console.ReadLine());

            foreach (var hero in list)
            {
                Console.WriteLine(hero.CastAbility());

                vilian -= hero.Power;
            }

            if (vilian <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
        private static BaseHero CreateNewHero(string name, string type)
        {
            BaseHero hero = null;

            if (type == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }
            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }

            return hero;
        }
    }
}

