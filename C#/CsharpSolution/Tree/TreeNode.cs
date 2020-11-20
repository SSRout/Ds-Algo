using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Tree
{
    class TreeNode<T> where T : IComparable
    {
        public T data;
        public TreeNode<T> leftChild;
        public TreeNode<T> rightChild;
        public TreeNode(T d)
        {
            this.data = d;
            leftChild = rightChild = null;
        }

        public TreeNode<T> tree = null;

        public void AddToTree(T data)
        {
            if (tree.data == null)
            {
                tree = new TreeNode<T>(data);
            }
            else if (tree.data.CompareTo(data)>0)
            {
                tree.leftChild= new TreeNode<T>(data);
            }
            else
            {
                tree.rightChild = new TreeNode<T>(data);
            }
        }
    }
}
