using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CsharpSolution.Tree
{
    public class AVLTree<T>
    {
        class Node<T>
        {
            public T data;
            public Node<T> left;
            public Node<T> right;
            public Node<T> paent;
            public Node(T obj)
            {
                data = obj;
                paent = left = right = null;
            }
        }

        private Node<T> root;
        private int currentSize;

        public AVLTree()
        {
            root = null;
            currentSize = 0;
        }

        public void Add(T obj)
        {
            Node<T> node = new Node<T>(obj);
            if (root == null)
            {
                root = node;
                currentSize++;
                return;
            }
            Add(root, node);
        }


        private void Add(Node<T> parent, Node<T> newNode)
        {
     
        }
    }
}
