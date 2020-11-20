using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    class SplitCircularLinkedList_inTwoParts
    {
        //Time Complexity: O(n). Space Complexity: O(1).
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

        public Node head = null, head1=null , head2 = null;

        public void push(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                node.next = head;
                head = node;
                return;
            }
            head = node;
        }
        public void Print(Node head)
        {
            Node temp = head;
            do
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine();
        }

        public void SplitList(Node head)
        {
            Node fp = head, sp = head;
            if (head == null)
                return;
            while (fp.next != head && fp.next.next != head)
            {
                fp = fp.next.next;
                sp = sp.next;
            }
            //if list is even
            if (fp.next.next ==head)
                fp = fp.next;

            //set the head pointer of first half
            head1 = head;

            //set the ghead pointer of Second half
            if (head.next != head)
                head2 = sp.next;

            //set secondhalf circular
            fp.next = sp.next;

            //set first half circular
            sp.next = head;

        }

    }
}
