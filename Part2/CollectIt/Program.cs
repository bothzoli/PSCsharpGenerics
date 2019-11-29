using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new Dictionary<string, List<Employee>>();

            employeesByDepartment.Add("Engineering",
                new List<Employee>() { new Employee{ Name = "Scott" } });

            employeesByDepartment["Engineering"]
                .Add(new Employee{ Name = "Allen" });

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
