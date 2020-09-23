using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Time Complexity: O(n). Space Complexity: O(n)→ for Stack
     */
    class PrintLinkedListFromEnd
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
        public Node a;
        public Node b;
        public Node c;
        public PrintLinkedListFromEnd()
        {
            a = new Node(10);
            b = new Node(20);
            c = new Node(30);
            a.next = b;
            b.next = c;
        }
        public void PrintFromEnd(Node head)
        {
            if (head == null)
            {
                return;
            }
            PrintFromEnd(head.next);
            Console.Write(head.data + " ");
        }

        public void Print()
        {
            PrintFromEnd(a);
            Console.WriteLine();
        }
    }
}
