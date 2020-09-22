using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
    public class Node_4<T>
    {
        public T data;
        public Node_4<T> next;
        public Node_4(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class DetectLoopInLinkedListUsingHasSet<T>
    {
        /*
         * Detect loop
         * Time complexity: O(n).Only one traversal of the loop is needed.
         * Auxiliary Space: O(n).n is the space required to store the value in hashmap.
         */

        public Node_4<T> head;
        
        
        
        
        public DetectLoopInLinkedListUsingHasSet()
        {
            this.head = null;
        }
        public void Push(T data)
        {
            Node_4<T> newNode = new Node_4<T>(data);
            newNode.next = head;
            head = newNode;
        }

        public void DetectLoop()
        {
            HashSet<Node_4<T>> hash = new HashSet<Node_4<T>>();
            while (head != null)
            {
                if (hash.Contains(head))
                {
                    Console.WriteLine($"Loop Detects at {head.data}");
                    return;
                }
                hash.Add(head);
                head = head.next;
            }
            Console.WriteLine($"Loop not Found");
        }
    }
}
