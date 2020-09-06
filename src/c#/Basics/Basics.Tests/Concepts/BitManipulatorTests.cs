using Basics.Concepts;
using Xunit;

namespace Basics.Tests.Concepts
{
    public class BitManipulatorTests
    {
        [Theory]
        [InlineData(0b10000000000, 0b10011, 2, 6, 0b10001001100)]
        [InlineData(0b11111111111, 0b10011, 2, 6, 0b11111001111)]
        public void When_inserting_number_in_host(
            int host, 
            int insert, 
            int i, 
            int j,
            int expectedAnswer)
        {
            var bitMan = new BitManipulator();
            var result = bitMan.InsertBinaryNumber(host, insert, i, j);
            
            Assert.Equal(expectedAnswer, result);
        }
    }
}