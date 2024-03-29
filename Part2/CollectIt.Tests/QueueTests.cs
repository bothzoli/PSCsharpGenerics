using System.Collections.Generic;
using Xunit;

namespace CollectIt.Tests
{
    public class QueueTests
    {
        [Fact]
        public void Can_Peek_At_Next_Item()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void Can_Search_With_Contains()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.True(queue.Contains(2));
        }

        [Fact]
        public void Can_Convert_Queue_To_Array()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var asArray = queue.ToArray();
            queue.Dequeue();

            Assert.Equal(1, asArray[0]);
            Assert.Equal(2, queue.Count);
        }   
    }
}
