using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Algorithms
{
    // Recursive algorithm with O(nln(n)) time and  and O(1) space
    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> original)
        {
            var array = original.ToArray();
            return QuickSort(array, 0, array.Length - 1);
        }

        private T[] QuickSort(T[] array, int beginning, int end)
        {
            if (beginning == end)
            {
                return array;
            }

            var pivot = end;
            var index = beginning;

            while (index < end)
            {
                if (array[index].CompareTo(array[pivot]) > 0
                    && pivot > index)
                {
                    SwapValues(array, pivot, index);
                    pivot = index;
                }
                else if (array[index].CompareTo(array[pivot]) < 0
                         && pivot < index)
                {
                    SwapValues(array, pivot, index);
                    var oldPivot = pivot;
                    pivot = index;
                    index = oldPivot;
                }

                index++;
            }

            if (beginning != pivot)
            {
                QuickSort(array, beginning, pivot - 1);
            }

            if (pivot != end)
            {
                QuickSort(array, pivot + 1, end);
            }

            return array;
        }

        private static void SwapValues(T[] array, int pivot, int index)
        {
            var temp = array[pivot];
            array[pivot] = array[index];
            array[index] = temp;
        }
    }
}