using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Plain Linked list with 
     * Prepend
     * Append
     * delete node
    */

    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            next = null;
            data = d;
        }
    }
    public class LinkedList
    {
        internal Node head;
        int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        internal void Prepend(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            count++;
        }

        internal void Append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                count++;
                return;
            }
            Node currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = new Node(data);

        }
        public void PrintList()
        {
            Node runner = head;
            while (runner != null)
            {
                Console.Write(runner.data.ToString() + " ");
                runner = runner.next;
            }
        }
    }
}
