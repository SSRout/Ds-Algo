using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Time Complexity: O(n)
     * Auxiliary Space: O(1)
     */
    class ReverseLinkedList<T>
    {
        public class Node {
            public T data;
            public Node next;
            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        Node head;
        public ReverseLinkedList()
        {
            head = null;
        }

        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        public void Push(T new_data)
        {
            //insert at end
            Node node = new Node(new_data);
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

        public void PrintList()
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
