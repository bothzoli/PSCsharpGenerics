using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee { Name = "Scott" });
            line.Enqueue(new Employee { Name = "Allen" });
            line.Enqueue(new Employee { Name = "Dani" });

            while (line.Count > 0)
            {
                Console.WriteLine(line.Dequeue().Name);
            }

            Console.WriteLine("---");

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee { Name = "Scott" });
            stack.Push(new Employee { Name = "Allen" });
            stack.Push(new Employee { Name = "Dani" });

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().Name);
            }
        }
    }
}
