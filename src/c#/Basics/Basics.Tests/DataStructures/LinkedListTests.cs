using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class LinkedListTests
    {
        [Fact]
        public void When_iterating_through_list()
        {
            var list = new LinkedList<int>();
            var insertedCount = 10;
            var insertedString = "";

            for (int i = 0; i < insertedCount; i++)
            {
                list.Add(i);
                insertedString += i;
            }

            var iteratedString = "";
            foreach (var i in list)
            {
                iteratedString += i;
            }

            Assert.Equal(insertedCount, list.Count);
            Assert.Equal(insertedString, iteratedString);
        }

        [Fact]
        public void When_iterating_through_empty_list()
        {
            var list = new LinkedList<int>();

            var iteratedString = "";
            foreach (var i in list)
            {
                iteratedString += i;
            }

            Assert.Equal(0, list.Count);
            Assert.Equal("", iteratedString);
        }
        
        [Fact]
        public void When_removing_first_from_empty()
        {
            var list = new LinkedList<int>();
            list.RemoveFirst();
            Assert.Empty(list);
            
            list.Add(1);
            Assert.Equal(1, list.Count);
        }
    }
}
