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

        protected Node reverseUtil(Node curr, Node prev)
        {
            /* If last node mark it head*/
            if (curr.next == null)
            {
                head = curr;

                /* Update next to prev node */
                curr.next = prev;

                return head;
            }

            /* Save curr->next node for recursive call */
            Node next = curr.next;

            /* and update next ..*/
            curr.next = prev;

            reverseUtil(next, curr);
            return head;
        }

        public void Reverse()
        {
           head=reverseUtil(head, null);
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
