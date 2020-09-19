using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Circular Linked list with 
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
    #region Circular Node
    internal class CList<T>
    {
        public T data;
        public CList<T> next;
        public CList(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
    #endregion
    class CircularLinkedList<T>
    {
        CList<T> head;
        public CircularLinkedList()
        {
            head = null;
        }
        #region Insert At First
        public void Prepend(T data)
        {
            CList<T> cNode = new CList<T>(data);
            cNode.next = cNode;
            if (head == null)//Insert First Time
            {
                head = cNode;
            }
            else
            {
                CList<T> temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                cNode.next = head;
                temp.next = cNode;
                head = cNode;
            }
        }
        #endregion

        #region Insert At End
        public void Append(T data)
        {
            if (head == null)//Insert First Time
            {
                Prepend(data);
            }
            else
            {
                CList<T> temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                CList<T> newNode = new CList<T>(data);
                temp.next = newNode;
                newNode.next = head;

            }
        }
        #endregion

        #region Print Count
        public void NodeSearch(T data)
        {
            if (head == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
            CList<T> node = head;
            int count = 0;
            do
            {
                if (node.data.Equals(data))
                {
                    Console.WriteLine($"{data} found at index {count + 1}");
                    return;
                }
                node = node.next;
                count += 1;
            } while (node != head);
            Console.WriteLine($"data not found");
        }
        #endregion

        #region Print Count
        public void NodeCount()
        {
            if (head == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
            CList<T> node = head;
            int count = 0;
            do
            {
                node = node.next;
                count += 1;
            } while (node != head);
            Console.WriteLine($"Circular list Length is {count}");
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
            CList<T> node = head;

            do
            {
                Console.Write(node.data + " ");
                node = node.next;
            } while (node != head);
            Console.WriteLine();
        }
        #endregion
    }
}
