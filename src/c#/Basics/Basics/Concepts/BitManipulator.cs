using System;

namespace Basics.Concepts
{
    public class BitManipulator
    {
        public int InsertBinaryNumber(int host, int insert, int endIndex, int startIndex)
        {
            var mask = "";
            for (int k = 0; k < startIndex - endIndex + 1; k++)
            {
                mask += "1";
            }

            var maskInt = Convert.ToInt32(mask, 2);
            var shiftedMask = maskInt << endIndex;

            var maskedHost = host & ~shiftedMask;
            
            var shiftedNumber = insert << endIndex;
            return maskedHost | shiftedNumber;
        }
    }
}