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

        //L Root R
        public void Travers_Inorder(TreeNode tree)
        {
            if (tree != null)
            {
                Travers_Inorder(tree.leftChild);
                Console.Write(tree.data + " ");
                Travers_Inorder(tree.rightChild);
            }
        }

        //Root L R
        public void Travers_Preorder(TreeNode tree)
        {
            if (tree != null)
            {
                Console.Write(tree.data + " ");
                Travers_Preorder(tree.leftChild);
                Travers_Preorder(tree.rightChild);
            }
        }

        //L R Root
        public void Travers_Postorder(TreeNode tree)
        {
            if (tree != null)
            {
                Travers_Postorder(tree.leftChild);
                Travers_Postorder(tree.rightChild);
                Console.Write(tree.data + " ");
            }
        }
    }
}
