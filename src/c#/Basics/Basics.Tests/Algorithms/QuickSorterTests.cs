using System;
using System.Collections.Generic;
using Basics.Algorithms;
using Xunit;

namespace Basics.Tests.Algorithms
{
    public class QuickSorterTests
    {
        [Theory]
        [InlineData(new[] {3, 6, 2}, new[] {2, 3, 6})]
        [InlineData(new[] {1, 2, 3, 4, 5, 6, 7, 0}, new[] {0, 1, 2, 3, 4, 5, 6, 7})]
        public void When_sorting(int[] input, int[] answer)
        {
            var sorter = new QuickSorter<int>();
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

            var sorter = new QuickSorter<int>();
            var sorted = sorter.Sort(numbers);

            numbers.Sort();

            Assert.Equal(sorted, numbers);
        }
    }
}