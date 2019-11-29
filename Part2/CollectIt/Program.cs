using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Employee> set = new HashSet<Employee>();
            var employee = new Employee { Name = "Scott" };
            set.Add(employee);
            set.Add(new Employee { Name = "Allen" });
            set.Add(employee);

            foreach (var item in set)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
