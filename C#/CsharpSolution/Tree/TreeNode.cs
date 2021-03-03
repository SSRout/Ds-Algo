using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Tree
{
    public class TreeNode
    {
        public int data;
        public TreeNode leftChild;
        public TreeNode rightChild;

        public TreeNode(int d)
        {
            this.data = d;
            leftChild = rightChild = null;
        }
    }

    public class TreeDs { 

        public TreeNode tree;
        
        public TreeNode CreateNode(int data)
        {
            tree = new TreeNode(data);
            return tree;
        }
        public TreeNode AddToTree(int data,TreeNode tree)
        {
            if (tree == null)
            {
                tree = CreateNode(data);
            }
            else if (Convert.ToInt32(tree.data) > Convert.ToInt32(data))
            {
                tree.leftChild = AddToTree(data, tree.leftChild);
            }
            else
            {
                tree.rightChild = AddToTree(data, tree.rightChild);
            }
            return tree;
        }
    }
}
