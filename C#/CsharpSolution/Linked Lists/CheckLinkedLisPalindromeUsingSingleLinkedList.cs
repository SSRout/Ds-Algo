using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CsharpSolution.Linked_Lists
{
    /*
    * Time complexity of the above method is O(n) ans space complexty O(1)
    */
    class CheckLinkedLisPalindromeUsingSingleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;

            public Node(T d)
            {
                this.data = d;
                next = null;
            }
        }

        public Node head=null;
        public Node tail = null;
        public int size;

        public void InsertFirst(T data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                tail = node;
                return;
            }
            tail.next = node;
            tail = node;
            size++;
        }

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

        public void CheckPalindrome()
        {
            Node current = head;
            bool flag = true;

            //Store the mid position of the list  
            int mid = (size % 2 == 0) ? (size / 2) : ((size + 1) / 2);

            //Finds the middle node in given singly linked list  
            for (int i = 1; i < mid; i++)
            {
                current = current.next;
            }
            //Reverse the list after middle node to end  
            Node revHead = reverseList(current.next);

            //Compare nodes of first half and second half of list  
            while (head != null && revHead != null)
            {
                if (!(head.data.Equals(revHead.data)))
                {
                    flag = false;
                    break;
                }
                head = head.next;
                revHead = revHead.next;
            }

            if (flag)
                Console.WriteLine("Given singly linked list is a palindrome");
            else
                Console.WriteLine("Given singly linked list is not a palindrome");
        }
        private Node reverseList(Node temp)
        {
            Node current = temp;
            Node prevNode = null, nextNode = null;
            //Swap the previous and next nodes of each node to reverse the direction of the list  
            while (current != null)
            {
                nextNode = current.next;
                current.next = prevNode;
                prevNode = current;
                current = nextNode;
            }
            return prevNode;
        }

    }
}
