using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    public class DetectLoopInLinkedListUsingBF<T>
    {
        /*
         * Time complexity:O(n).Only one traversal of the loop is needed.
         * Auxilary Space:O(1)
         */
        public class Node
        {
            public T data;
            public Node next;
            public int flag;
            public Node(T data)
            {
                this.data = data;
                this.next = null;
                this.flag = 0;
            }
        }

        public Node head;
        public DetectLoopInLinkedListUsingBF()
        {
            head = null;
        }
        public void Insert(T data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public string DetectLoop()
        {
            Node temp = head;
            while (temp.next != null)
            {           
                if (temp.flag == 1)
                {
                    return $"Loop Found";
                }
                temp.flag = 1;
                temp = temp.next;
            }
            return $"Not Found Loop";
        }
    }
}
