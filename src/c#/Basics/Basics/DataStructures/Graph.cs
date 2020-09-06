using System.Collections.Generic;
using System.Collections.Immutable;

namespace Basics.DataStructures
{
    public class Graph<T> where T : notnull
    {
        private readonly IDictionary<T, GraphNode<T>> Nodes;

        public Graph(IDictionary<T, IEnumerable<T>> adjacenyList)
        {
            Nodes = new Dictionary<T, GraphNode<T>>();
            
            foreach (var link in adjacenyList)
            {
                if (!Nodes.ContainsKey(link.Key))
                {
                    Nodes[link.Key] = new GraphNode<T>(link.Key, new List<GraphNode<T>>());
                }

                foreach (var neighbor in link.Value)
                {
                    if (!Nodes.ContainsKey(neighbor))
                    {
                        Nodes[neighbor] = new GraphNode<T>(neighbor, new List<GraphNode<T>>());
                    }

                    Nodes[link.Key].Neighbors.Add(Nodes[neighbor]);
                }
            }
        }

        public bool IsConnected(T start, T end)
        {
            var startNode = Nodes[start];
            var endNode = Nodes[end];

            IImmutableQueue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue = queue.Enqueue(startNode);

            var visited = new List<GraphNode<T>>();

            while (!queue.IsEmpty)
            {
                var current = queue.Peek();
                queue = queue.Dequeue();

                if (current == endNode)
                {
                    return true;
                }

                if (!visited.Contains(current))
                {
                    foreach (var n in current.Neighbors)
                    {
                        queue = queue.Enqueue(n);
                    }

                    visited.Add(current);
                }
            }

            return false;
        }

        //TODO Djikstra's SPF Algo
    }
}