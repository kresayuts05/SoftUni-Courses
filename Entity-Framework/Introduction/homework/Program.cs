using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');

            Employee employee = new Employee(elements[0], elements[1], int.Parse(elements[2]), int.Parse(elements[3]));

            double bonus = double.Parse(Console.ReadLine());

            employee.IncreaseSalary(bonus);

            Console.WriteLine($"{employee.FirstName} {employee.LastName} get {employee.Salary:f2} leva");

        }
    }
}
