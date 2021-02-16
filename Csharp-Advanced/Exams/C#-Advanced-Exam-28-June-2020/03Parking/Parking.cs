using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;

            data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }


        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (car != null)
            {
                data.Remove(car);
                return true;
            }

            return false;
        }

        public Car GetLatestCar()
        {
            Car car = data.OrderByDescending(c => c.Year).FirstOrDefault();

            if (car != null)
            {
                return car;
            }

            return null;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (car != null)
            {
                return car;
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"The cars are parked in {Type}:");

            foreach (var car in data)
            {
                output.AppendLine($"{car}");
            }

            return output.ToString().Trim();
        }
    }
}
