using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataStructures
{
    public static class BufferExtensions
    {
        public static void Dump<T>(this IBuffer<T> buffer, Action<T> print)
        {
            foreach (var item in buffer)
            {
                print(item);
            }
        }

        public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                var result = converter.ConvertTo(item, typeof(TOutput));
                yield return (TOutput)result;
            }
        }

        public static IEnumerable<TOutput> Map<T, TOutput>(this IBuffer<T> buffer, Converter<T, TOutput> converter)
        {
            foreach (var item in buffer)
            {
                yield return converter(item);
            }

            /*
            return buffer.Select(i => converter(i));
             */
        }
    }
}
