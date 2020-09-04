using System;
using Basics.DataStructures;
using Xunit;

namespace Basics.Tests.DataStructures
{
    public class BinaryTreeTests
    {
       
        
        [Fact]
        public void When_searching_for_number_breadth_first()
        {
            var bst = new BinaryTree<int>();
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
            
            Assert.True(bst.SearchBreadthFirst(target));
        }
        
        [Fact]
        public void When_searching_for_number_depth_first()
        {
            var bst = new BinaryTree<int>();
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
            
            Assert.True(bst.SearchDepthFirst(target));
        }
        
        [Fact]
        public void When_searching_for_number_recursively()
        {
            var bst = new BinaryTree<int>();
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
            
            Assert.True(bst.SearchRecursively(target));
        } 
    }
}