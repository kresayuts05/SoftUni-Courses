using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            data = new List<Employee>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);

            if (employee != null)
            {
                data.Remove(employee);
                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee employee = data.OrderByDescending(e => e.Age).FirstOrDefault();

            return employee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);

            return employee;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in data)
            {
                output.AppendLine(employee.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
