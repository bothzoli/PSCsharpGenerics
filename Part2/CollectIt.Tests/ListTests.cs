using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CollectIt.Tests
{
    public class ListTests
    {
        [Fact]
        public void A_List_Can_Insert()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            integers.Insert(1, 6);
            
            Assert.Equal(6, integers[1]);
        }

        [Fact]
        public void A_List_Can_Remove()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            integers.Remove(2);

            Assert.True(integers.SequenceEqual(new [] { 1,3 }));
        }

        [Fact]
        public void A_List_Can_Find_Things()
        {
            List<int> integers = new List<int> { 1, 2, 3 };

            Assert.Equal(2, integers.IndexOf(3));
        }
    }
}
