namespace Basics.DataStructures
{
    public class MaxHeap
    {
        private int _size;
        private readonly int[] _heap;

        public MaxHeap(int maxSize)
        {
            _heap = new int[maxSize + 1];
        }

        public void Add(int value)
        {
            _heap[++_size] = value;

            var index = _size;
            var parent = GetParent(index);

            while (_heap[index] > _heap[parent] && parent > 0)
            {
                Swap(index, parent);
                index = parent;
                parent = GetParent(index);
            }
        }

        public int PopMax()
        {
            var max = _heap[1];
            _heap[1] = _heap[_size--];
            Heapify(1);
            return max;
        }

        private void Heapify(in int current)
        {
            if (IsLeaf(current))
            {
                return;
            }

            if (_heap[current] >= _heap[GetLeftChild(current)] &&
                _heap[current] >= _heap[GetRightChild(current)]) return;

            if (_heap[GetLeftChild(current)] > _heap[GetRightChild(current)])
            {
                Swap(current, GetLeftChild(current));
                Heapify(GetLeftChild(current));

            }
            else
            {
                Swap(current, GetRightChild(current));
                Heapify(GetRightChild(current));
            }
        }

        private void Swap(in int index, in int parent)
        {
            var temp = _heap[index];
            _heap[index] = _heap[parent];
            _heap[parent] = temp;
        }

        private int GetParent(in int index)
        {
            return index / 2;
        }

        private bool IsLeaf(in int index)
        {
            return 2 * index > _size;
        }

        private int GetLeftChild(in int index)
        {
            return index * 2;
        }

        private int GetRightChild(in int index)
        {
            return index * 2 + 1;
        }
    }
}