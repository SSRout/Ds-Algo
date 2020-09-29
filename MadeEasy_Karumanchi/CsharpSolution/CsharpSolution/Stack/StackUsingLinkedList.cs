using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class StackUsingLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;
            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }

        private int length;
        private Node top;

        public StackUsingLinkedList()
        {
            length = 0;
            top = null;
        }
        //TC:O(1)
        public int GetSize()
        {
            return length;
        }

        //TC:O(1)
        public void Push(T data)
        {
            Node node = new Node(data);
            length += 1;
            node.next = top;
            top = node;
        }

        //TC:O(1)
        public T Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is Empty");
            }
            T result = top.data;
            top = top.next;
            length -= 1;
            return result;

        }

        //TC:O(1)
        public T Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is Empty");
            }
            return top.data;
        }

        public void Print()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
