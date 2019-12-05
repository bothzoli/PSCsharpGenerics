using System;

namespace DataStructures
{
    class Program
    {

        static void Main(string[] args)
        {
            Action<bool> print = d => Console.WriteLine(d);
            Func<double, double> sqare = d => d * d;
            Func<double, double, double> add = (x,y) => x + y;
            Predicate<double> isLessThanTen = d => d < 10;

            print(isLessThanTen(add(2, sqare(3))));

            Converter<double, string> converter = d => d.ToString();

            var buffer = new CircularBuffer<double>(capacity: 3);
            buffer.ItemDiscarded += ItemDiscarded;

            ProcessInput(buffer);

            var asInts = buffer.AsEnumerableOf<double, int>();

            buffer.Dump(d => Console.WriteLine(d));

            foreach (var item in asInts)
            {
                Console.WriteLine(item);
            }

            // Converter<double, DateTime> dateTimeConverter = d => new DateTime(2010, 1, 1).AddDays(d);
            // var asDates = buffer.Map(converter);
            var asDates = buffer.Map(d => new DateTime(2010, 1, 1).AddDays(d));

            foreach (var item in asDates)
            {
                Console.WriteLine(item);
            }

            ProcessBuffer(buffer);
        }

        private static void ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine($"Buffer full. Discarding {e.ItemDiscarded}, new item is {e.NewItem}");
        }

        private static void ProcessInput(IBuffer<double> buffer)
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

        private static void ProcessBuffer(IBuffer<double> buffer)
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
