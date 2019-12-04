using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new DepartmentCollection();

            employeesByDepartment
                .Add("Sales", new Employee { Name = "Scott" })
                .Add("Sales", new Employee { Name = "Alex" })
                .Add("Sales", new Employee { Name = "Dani" });
            
            employeesByDepartment
                .Add("Engineering", new Employee { Name = "Joy" })
                .Add("Engineering", new Employee { Name = "Dani" })
                .Add("Engineering", new Employee { Name = "Dani" });


            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");
                }
            }
        }
    }
}
