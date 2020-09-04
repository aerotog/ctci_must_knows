using System.Collections;
using System.Collections.Generic;

namespace Basics.DataStructures
{
    // This is doubly linked to make it faster when used in the Stack
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {
        }

        public LinkedList(IEnumerable<T> original)
        {
            if (original == null) return;
            foreach (var val in original) Add(val);
        }

        public int Count { get; private set; }
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public void Add(T thing)
        {
            var node = new LinkedListNode<T>(thing);
            if (Last != null)
            {
                Last.Next = node;
                node.Parent = Last;
                Last = node;
            }
            else
            {
                First = node;
                Last = First;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (First == null) return;
            First = First?.Next;
            Count--;
        }
        
        public void RemoveLast()
        {
            if (Last == null) return;
            Last = Last?.Parent;
            
            if (Last != null)
            {
                Last.Next = null;
            }
            
            Count--;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}