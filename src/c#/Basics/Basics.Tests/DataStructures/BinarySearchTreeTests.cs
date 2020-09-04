using System;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void When_searching_for_number()
        {
            var bst = new BinarySearchTree<int>();
            var random = new Random();
            var target = 0;
            
            for (int i = 0; i < 100; i++)
            {
                var number = random.Next(1000);
                bst.Add(number);
                if (i == 77)
                {
                    target = number;
                }
            }
            
            Assert.True(bst.Contains(target));
        }
    }
}