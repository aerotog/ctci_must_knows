using Basics.DataStructures;

namespace Basics.Algorithms
{
    public interface ISearcher<T>
    {
        bool Search(TreeNode<T> node, T target);
    }
}