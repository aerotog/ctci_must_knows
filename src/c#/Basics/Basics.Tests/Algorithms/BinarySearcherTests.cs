using System.Collections.Generic;
using Basics.Algorithms;
using Xunit;

namespace Basics.Tests.Algorithms
{
    public class BinarySearcherTests
    {
        [Fact]
        public void When_searching()
        {
            var numbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }
            
            var searcher = new BinarySearcher();
            
            Assert.True(searcher.Search(77, numbers.ToArray()));
        }
    }
}