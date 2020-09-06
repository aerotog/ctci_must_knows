using System.Collections.Generic;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class GraphTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void When_checking_if_connected(
            IDictionary<int, IEnumerable<int>> adjacencyList, 
            int start, 
            int end, 
            bool expectedResult)
        {
            var graph = new Graph<int>(adjacencyList);
            var isConnected = graph.IsConnected(start, end);
            Assert.Equal(expectedResult, isConnected);
        }

        public static IEnumerable<object[]> Data()
        {
            var adjacencyList1 = new Dictionary<int, IEnumerable<int>>
            {
                [1] = new List<int>() {2},
                [2] = new List<int>() {3},
                [3] = new List<int>() {5},
                [4] = new List<int>()
            };

            return new List<object[]>
            {
                new object[]{adjacencyList1, 1, 5, true},
                new object[]{adjacencyList1, 1, 4, false},
            };
        }
        
    }
}