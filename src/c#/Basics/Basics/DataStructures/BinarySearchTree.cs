using System;

namespace Basics.DataStructures
{
    /// <summary>
    /// Searching in a BST has time complexity O(h) where 'h' is the height.
    /// If values are inserted in order, h = n and time complexity becomes linear, O(n).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTree<T> where T : IComparable
    {
        private TreeNode<T>? _root;

        public void Add(T thing)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>(thing);
            }
            else
            {
                Add(thing, _root);
            }
        }

        public bool Contains(T thing)
        {
            return Contains(thing, _root);
        }

        private void Add(T thing, TreeNode<T> node)
        {
            if (thing.CompareTo(node.Value) <= 0)
            {
                if (node.Left != null)
                {
                    Add(thing, node.Left);
                }
                else
                {
                    node.Left = new TreeNode<T>(thing);
                }
            }
            else
            {
                if (node.Right != null)
                {
                    Add(thing, node.Right);
                }
                else
                {
                    node.Right = new TreeNode<T>(thing);
                }
            }
        }

        private bool Contains(T thing, TreeNode<T>? node)
        {
            if (node == null)
            {
                return false;
            }

            if (Equals(node.Value, thing))
            {
                return true;
            }

            var next = thing.CompareTo(node.Value) < 0
                ? node.Left
                : node.Right;
            return Contains(thing, next);
        }
    }
}