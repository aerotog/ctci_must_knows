using System.Collections;
using System.Collections.Generic;

namespace Basics.DataStructures
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedListNode<T>? _current;
        private LinkedList<T>? _list;

        public LinkedListEnumerator(LinkedList<T> list)
        {
            _list = list;
        }

        public bool MoveNext()
        {
            if (_current != null)
            {
                _current = _current.Next;
                return _current != null;
            }

            if (_current == null && _list!.First != null)
            {
                _current = _list.First;
            }

            return _current != null;
        }

        public void Reset()
        {
            _current = _list!.First;
        }

        public T Current => _current!.Value;

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            _list = null;
            _current = null;
        }
    }
}
