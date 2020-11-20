using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Linked_Lists
{
        /*
         * Time complexity:O(n).Only one traversal of the loop is needed.
         * Auxilary Space:O(1)
         */
    class DetectLoopInLinkedListUsing_FloydCycle<T>
    {
        public class Node
        {
            public T data;
            public Node next;
            public Node(T d)
            {
                data = d;
                next = null;
            }
        }

        public Node head = null;
        /* Inserts a new Node at front of the list. */
        public void push(T data)
        {
 
            Node new_node = new Node(data);
            new_node.next = head;
            head = new_node;
        }

        public void DetectLoop()
        {
            Node sp=head,fp = head;
            while(sp!=null && fp!=null && fp.next != null)
            {
                sp = sp.next;
                fp = fp.next.next;
                if (sp == fp)
                {
                    Console.WriteLine($"Loop Found");
                    return;
                }
                
            }
            Console.WriteLine($"No Loop Found");
        }
    }
}
