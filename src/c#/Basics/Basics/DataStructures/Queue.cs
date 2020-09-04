using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Basics.DataStructures
{
    // Using the ImmutableQueue System interface since there is no System Queue interface
    // Being immutable will make it more Functional since its calls do not mutate its own state
    public class Queue<T> : IImmutableQueue<T>
    {
        private readonly LinkedList<T> _list;

        public Queue()
            : this(new LinkedList<T>())
        {
        }

        private Queue(LinkedList<T> list)
        {
            _list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IImmutableQueue<T> Clear()
        {
            return new Queue<T>(new LinkedList<T>());
        }

        public IImmutableQueue<T> Dequeue()
        {
            var newList = new LinkedList<T>(_list);
            newList.RemoveFirst();
            return new Queue<T>(newList);
        }

        public IImmutableQueue<T> Enqueue(T value)
        {
            var newList = new LinkedList<T>(_list) {value};
            return new Queue<T>(newList);
        }

        public T Peek()
        {
            return _list.First != null ? _list.First.Value : default(T);
        }

        public bool IsEmpty => _list.Count == 0;
    }
}