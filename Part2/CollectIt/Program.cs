using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new SortedDictionary<string, List<Employee>>();

            employeesByDepartment.Add("Sales",
                new List<Employee>() { new Employee{ Name = "Scott" } });

            employeesByDepartment.Add("Engineering",
                new List<Employee>() { new Employee{ Name = "Allen" } });

            foreach (var department in employeesByDepartment)
            {
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"{department.Key}: {employee.Name}");
                }
            }
        }
    }
}
