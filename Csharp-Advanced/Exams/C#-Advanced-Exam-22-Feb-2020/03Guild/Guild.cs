using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            roster = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return roster.Count; } }


        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);

            if (player != null)
            {
                roster.Remove(player);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);

            if (player != null)
            {
                if (player.Rank != "Member")
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);

            if (player != null)
            {
                if (player.Rank != "Trial")
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string class1)
        {
            Player[] myListTemp = roster.Where(x => x.Class == class1).ToArray();

            foreach (var player in myListTemp)
            {
                roster.Remove(player);
            }

            return myListTemp;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roster)
            {
                output.AppendLine(player.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
