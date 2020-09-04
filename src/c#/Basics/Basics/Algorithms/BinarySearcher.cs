using System.Linq;

namespace Basics.Algorithms
{
    public class BinarySearcher
    {
        public bool Search(int target, int[]? list)
        {
            if (list == null)
            {
                return false;
            }
            
            if (target < list.First() || target > list.Last())
            {
                return false;
            }

            var beginning = 0;
            var end = list.Length - 1;
            var index = beginning;

            while (list[index] != target)
            {
                if (target < list[index])
                {
                    end = index;
                }
                else
                {
                    beginning = index;
                }

                index = (beginning + end) / 2;

                if (index == beginning || index == end)
                {
                    break;
                }
            }

            return list[index] == target;
        }
    }
}