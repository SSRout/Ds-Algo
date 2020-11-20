using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    //TC:O(n)
    class Merge2SortedLinkedList
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

        public Node Append(int data, Node h)
        {
            Node n = new Node(data);
            if (h == null)
            {
                h = n;
            }
            else
            {
                Node t = h;
                while (t.next != null)
                {
                    t = t.next;
                }
                t.next = n;
            }
            return h;
        }
        //List 1
        public Node h1;
        public void CreateList1()
        {
            int[] l1 = { 10, 40, 60, 70, 90 };
            for (int i = 0; i < l1.Length; i++)
            {
                h1 = Append(l1[i], h1);
            }
        }

        //List 2
        public Node h2;
        public void CreateList2()
        {
            int[] l2 = { 20, 30, 50, 80, 100 };
            for (int i = 0; i < l2.Length; i++)
            {
                h2 = Append(l2[i], h2);
            }
        }

        public Node head;
        public void MegeList(Node h1,Node h2)
        {
            Node S=null;
            if (h1 == null || h2 == null)
                return;
            if (h1!=null && h2!=null)
            {
                if (h1.data >= h2.data)
                {
                    S = h2;
                    h2 = S.next;
                }
                else
                {
                    S = h1;
                    h1 = S.next;
                }
                head = S;
            }
            while (h1 != null && h2 != null)
            {
                if (h1.data >= h2.data)
                {
                    S.next = h2;
                    S = h2;
                    h2 = S.next;
                }
                else
                {
                    S.next = h1;
                    S = h1;
                    h1 = S.next;
                }             
            }
            if (h1 == null)
            {
                S.next = h2;
            }
            if (h2 == null)
            {
                S.next = h1;
            }
        }

        public void Print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}
