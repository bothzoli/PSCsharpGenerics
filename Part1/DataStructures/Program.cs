using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new Buffer<double>();

            ProcessBuffer(buffer);
            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }
            ProcessInput(buffer);
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
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

        private static void ProcessInput(IBuffer<double> buffer)
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
