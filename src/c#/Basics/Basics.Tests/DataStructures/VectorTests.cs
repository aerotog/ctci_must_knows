using System.Collections.Generic;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class VectorTests
    {
        [Fact]
        public void When_growing_vector()
        {
            var vector = new Vector<int>();

            var added = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                vector.Add(i);
                added.Add(i);
            }

            var iterated = new List<int>();
            foreach (var value in vector)
            {
                iterated.Add(value);
            }

            Assert.Equal(added, iterated);
        }
    }
}