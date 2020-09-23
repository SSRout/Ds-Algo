using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Time Complexity: O(n) on average (assuming that hash table access time is O(1) on average). 
     */
    class RemovingDuplicateFromUnsortedLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        public Node head = null;

        //insert at first
        public void Push(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void RemoveDuplicate()
        {
            Node prev = null;
            Node cur = head;
            HashSet<int> key = new HashSet<int>();
            while (cur != null)
            {
                if (key.Contains(cur.data))
                {
                    prev.next = cur.next;
                }
                else
                {
                    key.Add(cur.data);
                    prev = cur;
                }
                cur = cur.next;
            }
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
