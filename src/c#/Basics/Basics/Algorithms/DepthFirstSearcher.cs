using System.Collections.Immutable;
using Basics.DataStructures;

namespace Basics.Algorithms
{
    public class DepthFirstSearcher<T> : ISearcher<T>
    {
        public bool Search(TreeNode<T> node, T target)
        {
            IImmutableStack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack = stack.Push(node);

            while (stack.IsEmpty != true)
            {
                var next = stack.Peek();
                stack = stack.Pop();

                if (Equals(next.Value, target))
                {
                    return true;
                }

                if (next.Left != null)
                {
                    stack = stack.Push(next.Left);
                }

                if (next.Right != null)
                {
                    stack = stack.Push(next.Right);
                }
            }
            
            return false;
        }
    }
}