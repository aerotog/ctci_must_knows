using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Algorithms
{
    // Recursive algorithm with O(nln(n)) time and space
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> original)
        {
            var originalArray = original.ToArray();

            if (originalArray.Length <= 1)
            {
                return originalArray;
            }

            var half = originalArray.Count() / 2;
            var left = originalArray.Take(half);
            var right = originalArray.Skip(half);

            var leftSorted = Sort(left).ToArray();
            var rightSorted = Sort(right).ToArray();

            return Merge(leftSorted, rightSorted);
        }

        private static IEnumerable<T> Merge(T[] leftSorted, T[] rightSorted)
        {
            var leftIndex = 0;
            var rightIndex = 0;

            var sorted = new List<T>();

            while (leftIndex < leftSorted.Length || rightIndex < rightSorted.Length)
            {
                if (leftIndex == leftSorted.Length)
                {
                    sorted.Add(rightSorted[rightIndex]);
                    rightIndex++;
                }
                else if (rightIndex == rightSorted.Length)
                {
                    sorted.Add(leftSorted[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    if (leftSorted[leftIndex].CompareTo(rightSorted[rightIndex]) <= 0)
                    {
                        sorted.Add(leftSorted[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        sorted.Add(rightSorted[rightIndex]);
                        rightIndex++;
                    }
                }
            }

            return sorted;
        }
    }
}