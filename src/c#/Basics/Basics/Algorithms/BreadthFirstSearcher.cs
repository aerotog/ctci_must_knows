using System.Collections.Immutable;
using Basics.DataStructures;

namespace Basics.Algorithms
{
    public class BreadthFirstSearcher<T> : ISearcher<T>
    {
        public bool Search(TreeNode<T> node, T target)
        {
            IImmutableQueue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue = queue.Enqueue(node);

            while (queue.IsEmpty != true)
            {
                var next = queue.Peek();
                queue = queue.Dequeue();

                if (Equals(next.Value, target))
                {
                    return true;
                }

                if (next.Left != null)
                {
                    queue = queue.Enqueue(next.Left);
                }

                if (next.Right != null)
                {
                    queue = queue.Enqueue(next.Right);
                }
            }

            return false;
        }
    }
}