using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Doubly Linked list with 
     * Prepend
     * Append
     * InsertAtMiddle
     * Search Node
     * Delete node
     * Length of list
     * Print List
    */

    #region Double Node
    internal class DoubleNode<T>
    {
        internal T data;
        internal DoubleNode<T> next;
        internal DoubleNode<T> prev;
        public DoubleNode(T data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }
    #endregion
    class DoublyLinkedList<T>
    {
        DoubleNode<T> head;
        public DoublyLinkedList()
        {
            head = null;
        }

        #region Insert At First
        public void Prepend(T data)
        {
            DoubleNode<T> dnode = new DoubleNode<T>(data);
            dnode.next = head;
            dnode.prev = null;
            if (head != null)
            {
                head.prev = dnode;
            }
            head = dnode;

        }
        #endregion

        #region Insert At Last
        public void Append(T data)
        {
            DoubleNode<T> temp = new DoubleNode<T>(data);
            temp.next = null;
            DoubleNode<T> current = head;
            //if list is empty
            if (current == null)
            {
                temp.prev = null;
                head = temp;
                return;
            }
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;
            temp.prev = current;
        }
        #endregion
        public void InsertAtMiddle(T data,int position)
        {
            int k = 1;
            DoubleNode<T> newNode = new DoubleNode<T>(data);
            if (position == 1)
            {
                newNode.next = head;//insert at begining First Time
                newNode.prev = null;
                if (head != null)
                {
                    head.prev = newNode;
                }
                head = newNode;
                return;
            }

            DoubleNode<T> temp = head;
            while((k<position) && (temp.next != null))
            {
                temp = temp.next;
                k++;
            }

            if (k != position-1)
            {
                Console.WriteLine($"Poisition not found at position {position}");
                return;
            }
            newNode.next = temp.next;
            newNode.prev = temp;
            if(temp.next!=null)
            {
                temp.next.prev = newNode;
            }
            temp.next = newNode;
            return;
        }
        #region Insert At Middle

        #endregion

        #region Print List
        public void PrintList()
        {
            DoubleNode<T> node = head;
            while (node!= null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
        #endregion

    }
}
