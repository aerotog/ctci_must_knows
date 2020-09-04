using System;
using System.Collections.Generic;
using Basics.Algorithms;
using Xunit;

namespace Basics.Tests.Algorithms
{
    public class MergeSorterTests
    {
        [Theory]
        [InlineData(new[] {3, 6, 2}, new[] {2, 3, 6})]
        public void When_sorting(int[] input, int[] answer)
        {
            var sorter = new MergeSorter<int>();
            var sorted = sorter.Sort(input);
            Assert.Equal(sorted, answer);
        }

        [Fact]
        public void When_sorting_random_numbers()
        {
            var random = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(100));
            }

            var sorter = new MergeSorter<int>();
            var sorted = sorter.Sort(numbers);

            numbers.Sort();

            Assert.Equal(sorted, numbers);
        }
    }
}