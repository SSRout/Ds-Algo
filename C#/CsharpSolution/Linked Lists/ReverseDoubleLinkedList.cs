using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CsharpSolution.Linked_Lists
{

    class ReverseDoubleLinkedList
    {
        public class DNode
        {
            public int data;
            public DNode next;
            public DNode prev;
            public DNode(int data)
            {
                this.data = data;
                next = null;
                prev = null;
            }
        }

        public DNode head = null;
        public void Print()
        {
            DNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        protected DNode GetNode(int data)
        {
            DNode node = new DNode(data);
            node.next = null;
            node.prev = null;
            return node;
        }

        public void Insert(int data)
        {
            DNode newNode= GetNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            head.prev = newNode;
            newNode.next = head;
            head = newNode;
        }

        public void Reverse()
        {
            DNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.prev;
            }
            Console.WriteLine();
        }
    }
}
