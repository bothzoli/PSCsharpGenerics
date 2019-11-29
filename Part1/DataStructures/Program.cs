﻿using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new CircularBuffer<double>(capacity: 3);

            ProcessBuffer(buffer);
            ProcessInput(buffer);
        }

        private static void ProcessBuffer(CircularBuffer<double> buffer)
        {
            while(true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }

        private static void ProcessInput(CircularBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while(!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }
    }
}
