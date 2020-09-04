using System.Linq;

namespace Basics.DataStructures
{
    public class ModalNode<T>
    {

        public ModalNode(T value, int mode)
        {
            Value = value;
            Neighbors = new ModalNode<T>[mode];
        }

        public ModalNode<T>[] Neighbors { get; }

        public T Value { get; }
        
        public int Mode => Neighbors.Count();
    }
}