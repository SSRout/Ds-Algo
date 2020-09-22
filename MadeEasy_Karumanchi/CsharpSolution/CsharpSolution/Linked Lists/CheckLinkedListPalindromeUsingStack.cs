using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{

    /*
     * Time complexity of the above method is O(n)
     */
    class CheckLinkedListPalindromeUsingStack<T>
    {
        public class Node
        {
            public T data;
            public Node next;
            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        Node head = null;

        public void Push(T data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void CheckPalindrome()
        {
            Stack<T> s = new Stack<T>();
            Node temp = head;
            bool flag = true;
            while (temp != null)
            {
                s.Push(temp.data);
                temp = temp.next;
            }

            while (head != null)
            {
                T c = s.Pop();
                if (head.data.Equals(c))
                {
                    
                    flag=true;
                }
                else
                {
                    flag = false;
                    break;
                }
                head = head.next;
            }
            if(flag)
                Console.WriteLine("List is Palindrome");
            else 
                Console.WriteLine("Not Plindrome");
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
    }
}
