using System.Collections;
using System.Collections.Generic;

namespace Basics.DataStructures
{
    public class VectorEnumerator<T> : IEnumerator<T>
    {
        private Vector<T> _vector;
        private int _currentIndex;
        private int _lastIndex;

        public VectorEnumerator(Vector<T> vector, int lastIndex)
        {
            _vector = vector;
            _lastIndex = lastIndex;
        }

        public bool MoveNext()
        {
            if (_currentIndex == _lastIndex)
            {
                return false;
            }

            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public T Current => _vector[_currentIndex];

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            _vector = null!;
        }
    }
}