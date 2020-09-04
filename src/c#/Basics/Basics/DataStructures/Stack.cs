using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Basics.DataStructures
{
    public class Stack<T> : IImmutableStack<T>
    {
        private LinkedList<T> _list;

        public Stack()
            : this(new LinkedList<T>())
        {

        }

        private Stack(LinkedList<T> list)
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

        public IImmutableStack<T> Clear()
        {
            return new Stack<T>();
        }

        public T Peek()
        {
            return _list.Last != null ? _list.Last.Value : default(T);
        }

        public IImmutableStack<T> Pop()
        {
            var newList = new LinkedList<T>(_list);
            newList.RemoveLast();
            return new Stack<T>(newList);
        }

        public IImmutableStack<T> Push(T value)
        {
            var newList = new LinkedList<T>(_list) {value};
            return new Stack<T>(newList);
        }

        public bool IsEmpty => _list.Count == 0;
    }
}