/* BinaryTreeNode.cs
 * Author: Rod Howell */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable generic binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements stored in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Gets this node's left child.
        /// </summary>
        public LeftistTree<T> LeftChild { get; }

        /// <summary>
        /// Gets this node's right child.
        /// </summary>
        public LeftistTree<T> RightChild { get; }
        /// <summary>
        /// The distance to an empty root
        /// </summary>
        private int _nullLength = 0;

        /// <summary>
        /// Constructs a BinaryTreeNode with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="first">The first child.</param>
        /// <param name="second">The second child.</param>
        public LeftistTree(T data, LeftistTree<T> first, LeftistTree<T> second)
        {
            Data = data;
            if (NullPathLength(first) < NullPathLength(second)) {
                RightChild = first;
                LeftChild = second;
            }
            else
            {
                RightChild = second;
                LeftChild = first;
            }
           // LeftChild = left;
           // RightChild = right;
            _nullLength = NullPathLength(RightChild) + 1;
        }
        /// <summary>
        /// Finds the null path length
        /// </summary>
        /// <param name="t">the tree</param>
        /// <returns>the null path length</returns>
        public static int NullPathLength(LeftistTree<T> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return t._nullLength;
            }
        }
    }
}
