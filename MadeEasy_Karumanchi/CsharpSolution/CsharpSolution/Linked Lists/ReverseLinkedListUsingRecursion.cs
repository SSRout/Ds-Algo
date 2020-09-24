using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
    * Time Complexity: O(n)
    * Auxiliary Space: O(n)
    */
    class ReverseLinkedListUsingRecursion
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public Node head;
        public ReverseLinkedListUsingRecursion()
        {
            head = null;
        }

        public Node reverseUtil(Node temp)
        {
            if (temp.next == null)
            {
                head = temp;
                return head;
            }
            reverseUtil(temp.next);
            Node cur = temp.next;
            cur.next = temp;
            temp.next = null;
            return head;
        }

        public void Reverse()
        {
           head=reverseUtil(head);
        }
        //inser at end
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node cur = head;
                while (cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = node;
            }
        }

        public void Print()
        {
            Node temp = head;
            while (temp!= null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
