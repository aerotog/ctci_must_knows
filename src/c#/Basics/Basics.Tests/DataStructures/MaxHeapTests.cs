using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class MaxHeapTests
    {
        [Fact]
        public void When_popping_max_from_heap()
        {
            var heap = new MaxHeap(100);
            var random = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                var number = random.Next(1000);

                if (numbers.Any() && number > numbers.Max())
                {
                    Debugger.Break();
                }
                
                heap.Add(number);
                numbers.Add(number);
            }

            var heapMax = heap.PopMax();
            
            Assert.Equal(numbers.Max(), heapMax);
        }
    }
}