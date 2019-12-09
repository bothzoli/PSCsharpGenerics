using System;
using System.Linq;

namespace QueryIt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IRepository<Employee> employeeRepository = new EmployeeRepository<Employee>(new EmployeeDb()))
            {
                //AddEmployees(employeeRepository);
                CountEmployees(employeeRepository);
            }
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            // employeeRepository.Add(new Employee { Name = "Scott" });
            employeeRepository.Add(new Employee { Name = "Alex" });
            employeeRepository.Commit();
        }

        private static void CountEmployees(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine(employeeRepository.FindAll().Count());
        }
    }
}
