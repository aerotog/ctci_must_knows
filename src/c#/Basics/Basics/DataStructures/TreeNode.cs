namespace Basics.DataStructures
{
    public class TreeNode<T>
    {
        public TreeNode(T value)
        {
            Value = value;
        }

        public TreeNode<T>? Left { get; set; }
        public TreeNode<T>? Right { get; set; }
        public T Value { get; }
    }
}