using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Employee
    {
        public Employee(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age < 30)
            {
                this.Salary += this.Salary * (bonus / 2)/100;
            }
            else
            {
                this.Salary += this.Salary * bonus/100;
            }
        }
    }
}
