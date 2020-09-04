using System;
using System.Collections.Immutable;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class QueueTests
    {
        [Fact]
        public void When_queueing_numbers()
        {
            IImmutableQueue<int> queue = new Queue<int>();

            var queuedString = "";
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var number = random.Next(100);
                queue = queue.Enqueue(number);
                queuedString += number;
            }

            var dequeuedString = "";
            while (queue.IsEmpty != true)
            {
                var dequeued = queue.Peek();
                dequeuedString += dequeued;
                queue = queue.Dequeue();
            }

            Assert.Equal(queuedString, dequeuedString);
        }

        [Fact]
        public void When_peeking_empty_queue()
        {
            var queue = new Queue<int>();
            var value = queue.Peek();
            Assert.Equal(default(int), value);
        }
    }
}
