using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{

    //Time Complexity – O(n). Space Complexity - O(1).
    class ReverseLinkedListPairWise
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

        public void Push(int d)
        {
            Node node = new Node(d);
            if (head != null)
            {
                node.next = head;
                head = node;
            }
            else
            {
                head = node;
            }
        }
     
        //recursion
        protected Node ReversePair(Node head)
        {
            Node temp = head;
            if (head == null || head.next == null)
            {
                return head;
            }
            else
            {
                temp = head.next;
                head.next = temp.next;
                temp.next = head;
                head = temp;
                head.next.next = ReversePair(head.next.next);
                return head;
            }

        }

        public void Reverse()
        {
            head = ReversePair(head);
        }
    }
}
