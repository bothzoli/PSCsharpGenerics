using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
                new Employee { Name = "Scott" },
                new Employee { Name = "Allen" }
            };

            employees.Add(new Employee { Name = "Dani" });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
