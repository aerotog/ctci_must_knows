using System.Collections;
using System.Collections.Generic;

namespace Basics.DataStructures
{
    public class Vector<T> : IEnumerable<T>
    {
        private T[] _store = new T[8];
        private int _index;

        public T this[int index] => _store[index];

        public int Length => _store.Length;

        public void Add(T value)
        {
            if (_index == _store.Length - 1)
            {
                var oldStore = _store;
                _store = new T[_store.Length*2];

                for (int i = 0; i < oldStore.Length; i++)
                {
                    _store[i] = oldStore[i];
                }
            }

            _store[++_index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new VectorEnumerator<T>(this, _index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}