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
     * Time Complexity: O(n), for scanning the complete list of size n.
     * Space Complexity: O(1), for temporary variable.
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

        #region Insert At Middle or Insert At Position
        public void InsertAtMiddle(T data, int position)
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
            while ((k < position-1) && (temp.next != null))
            {
                temp = temp.next;
                k++;
            }

            if (k < position-1)
            {
                Console.WriteLine($"Poisition not found at position {position}");
                return;
            }
            newNode.next = temp.next;
            newNode.prev = temp;
            if (temp.next != null)
            {
                temp.next.prev = newNode;
            }
            temp.next = newNode;
            return;
        }
        #endregion

        #region Delete Node
        public void Delete(int position)
        {
            int k = 1;
            if (head == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
            //First Node
            if (position == 1)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                    return;
                }
            }
           
            DoubleNode<T> temp = head;
            DoubleNode<T> temp2 = null;
            while (temp.next!= null)
            {
                k++;
                if (position == k)
                {
                    temp2 = temp.next.prev;
                    if (temp.next.next != null)
                    {
                        temp.next = temp.next.next;
                        temp.next.prev = temp2.prev;
                    }
                    else
                    {
                        temp.next = null;
                    }
                    return;
                }
                temp = temp.next;
            }

        }
        #endregion

        #region Node Count
        public void NodeCount()
        {
            DoubleNode<T> temp = head;
            if (head == null)
            {
                Console.Write("\nEmpty List");
                return;
            }
            int count = 0;
            while (temp.next != null)
            {
                temp = temp.next;
                count += 1;
            }
            Console.WriteLine($"List Length is {count+1}");
        }
        #endregion

        #region Node Search
        public void NodeSearch(T data)
        {
            DoubleNode<T> temp = head;
            if (head == null)
            {
                Console.Write("\nEmpty List");
                return;
            }
            int count = 1;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine($"{data} found at index {count}");
                    return;
                }
                temp = temp.next;
                count += 1;
            }
            Console.WriteLine($"{data} Not  found in List");
        }
        #endregion

        #region Print List
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
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
