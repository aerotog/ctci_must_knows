using System.Collections.Generic;

namespace Basics.DataStructures
{
    public class GraphNode<T>
    {

        public GraphNode(T value, IList<GraphNode<T>> neighbors)
        {
            Value = value;
            Neighbors = neighbors;
        }

        public IList<GraphNode<T>> Neighbors { get; }
        
        public T Value { get; }
    }
}