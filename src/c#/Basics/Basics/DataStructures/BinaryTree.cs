using System;
using Basics.Algorithms;

namespace Basics.DataStructures
{
    /// <summary>
    /// A binary tree has no inherent order so searching is always O(n) time complexity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T> where T : IComparable
    {
        private TreeNode<T> _root;
        private TreeNode<T> _tail;

        public void Add(T thing, TreeNode<T> node = null)
        {
            var newNode = new TreeNode<T>(thing);
            if (_root == null)
            {
                _root = newNode;
                _tail = _root;
            }
            else
            {
                if (_tail.Left == null)
                {
                    _tail.Left = newNode;
                }
                else
                {
                    _tail.Right = newNode;
                    _tail = newNode;
                }
            }
        }

        public bool SearchBreadthFirst(T thing)
        {
            if (_root == null)
            {
                return false;
            }
            
            var bfs = new BreadthFirstSearcher<T>();
            return bfs.Search(_root, thing);
        }

        public bool SearchDepthFirst(T thing)
        {
            if (_root == null)
            {
                return false;
            }
            
            var dfs = new DepthFirstSearcher<T>();
            return dfs.Search(_root, thing);
        }

        public bool SearchRecursively(T thing)
        {
            return SearchRecursively(thing, _root);
        }

        private bool SearchRecursively(T thing, TreeNode<T> node)
        {
            if (node == null) return false;
            
            if (Equals(node.Value, thing))
            {
                return true;
            }

            return SearchRecursively(thing, node.Left) || SearchRecursively(thing, node.Right);
        }
    }
}