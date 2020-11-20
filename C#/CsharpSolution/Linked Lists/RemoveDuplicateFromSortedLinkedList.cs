using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     *Time Complexity: O(n) where n is number of nodes in the given linked list
     */

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
    class RemoveDuplicateFromSortedLinkedList
    {
        Node head;
        public RemoveDuplicateFromSortedLinkedList()
        {
            head = null;
        }

        public void Insert(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void RemoveDuplicate()
        {
            Node temp = head;
            Node cur = null;
            while (temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    cur = temp.next.next;
                    temp.next = cur;
                }
                temp = temp.next;
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
