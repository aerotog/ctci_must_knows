using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class StackTests
    {
        [Fact]
        public void When_stacking_numbers()
        {
            IImmutableStack<int> stack = new Basics.DataStructures.Stack<int>();

            var stackedNumbers = new List<int>();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var number = random.Next(100);
                stack = stack.Push(number);
                stackedNumbers.Add(number);
            }

            var poppedNumbers = new List<int>();
            while (stack.IsEmpty != true)
            {
                var value = stack.Peek();
                poppedNumbers.Add(value);
                stack = stack.Pop();
            }

            stackedNumbers.Reverse();
            Assert.Equal(stackedNumbers, poppedNumbers);
        }
    }
}