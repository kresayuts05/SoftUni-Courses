using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            data = new List<Racer>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Racer racer) // TODO: make racer with big letter
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);

            if (racer != null)
            {
                data.Remove(racer);
                return true;
            }

            return false;
        }

        public Racer GetOldestRacer()
        {
            Racer racer = data.OrderByDescending(r => r.Age).FirstOrDefault();

            return racer; // TODO: return null if not exist
        }

        public Racer GetRacer(string name)
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);

            return racer;
        }

        public Racer GetFastestRacer()
        {
            Racer racer = data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();

            return racer;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in data)
            {
                output.AppendLine(racer.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
