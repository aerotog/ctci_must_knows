namespace Basics.DataStructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T thing)
        {
            Value = thing;
        }

        public T Value { get; }

        public LinkedListNode<T>? Next { get; set; }
        
        public LinkedListNode<T>? Parent { get; set; }
    }
}
