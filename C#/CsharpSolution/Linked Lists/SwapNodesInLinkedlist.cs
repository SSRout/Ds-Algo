using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Time Complexity:O(n)
     */
    class SwapNodesInLinkedlist
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

        public void PrintUsingRecursion(Node head)
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            Console.Write(temp.data + " ");
            PrintUsingRecursion(temp.next);
        }

        //insert at begining
        public void  Push(int data)
        {
            Node node = new Node(data);
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

        public void Swap(int a,int b)
        {
            if (a == b)
            {
                return;
            }
            Node temp = head;
            Node x=null, y = null;
            while (temp.next != null)
            {
                if (temp.next.data == a)
                {
                    x = temp;
                }
                if (temp.next.data == b)
                {
                    y = temp;
                }
                temp = temp.next;
            }

            if(x!=null && y != null)
            {
                Node cur;
                cur = x.next;
                x.next=y.next;
                y.next = cur;
                cur = x.next.next;
                x.next.next = y.next.next;
                y.next.next = cur;
            }
        }
    }
}
