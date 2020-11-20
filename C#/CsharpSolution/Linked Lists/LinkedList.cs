using System;

namespace CsharpSolution.Linked_Lists
{
    /*
     * Single Linked list with 
     * Prepend
     * Append
     * InsertAfter
     * InsertBefore
     * Search Node
     * Delete node
     * Length of list
     * Print List
     * Time Complexity: O(n), for scanning the complete list of size n.
     * Space Complexity: O(1), for temporary variable.
    */


    #region Single Node
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        public Node(T data)
        {
            next = null;
            this.data = data;
        }
    }
    #endregion


    public class LinkedList<T>
    {
        internal Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        #region Insert At First
        internal void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = head;
            head = newNode;
        }
        #endregion

        #region Insert At Last
        internal void Append(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                //or
                // Prepend(data);
                return;
            }
            Node<T> currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = new Node<T>(data);

        }
        #endregion

        #region Insert After Node
        public void InsertAfter(T data, T key)
        {
            if (head == null) return;
            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(key))
                {
                    Node<T> node = new Node<T>(data);
                    node.next = current.next;
                    current.next = node;
                    return;
                }
                if (current.next == null)
                {
                    Console.WriteLine($"{key} Node is Not Found in List to insert new Node {data} After.");
                    return;
                }
                current = current.next;
            }
        }
        #endregion

        #region Insert Before Node
        public void InsertBefore(T data, T key)
        {
            if (head == null) return;

            if (head.data.Equals(key))
            {
                Prepend(data);
                return;
            }
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null )
            {
                if (current.data.Equals(key))
                {
                    Node<T> node = new Node<T>(data);

                    previous.next = node;
                    node.next = current;
                    return;
                }
                if (current.next == null)
                {
                    Console.WriteLine($"{key} Node is Not Found in List to insert new Node {data} Before.");
                    return;
                }
                previous = current;
                current = current.next;
            }
        }
        #endregion

        #region Delete Node
        public void DelteNode(T data)
        {
            if (head == null) return;
            //delete head node
            if (head.data.Equals(data))
            {
                head = head.next;
                return;
            }
            Node<T> current = head;
            while (current.next != null)
            {
                if (current.next.data.Equals(data))
                {
                    current.next = current.next.next;
                    return;
                }
                
                current = current.next;
            }
            if (current.next == null)
            {
                Console.WriteLine($"{data} Node is Not Found in List to delete.");
                return;
            }
        }
        #endregion

        #region Search Node
        public void SearchNode(T key)
        {
            int count = 1;
            Node<T> cur = head;
            while (cur != null)
            {
                if (cur.data.Equals(key))
                {
                    Console.WriteLine($"{key} found at index {count}");
                    return;
                }
                count += 1;
                cur = cur.next;
            }
        }
        #endregion

        #region List Length
        public int NodeCount()
        {
            int count = 0;
            Node<T> runner = head;
            while (runner != null)
            {
                count += 1;
                runner = runner.next;
            }
            return count;
        }
        #endregion

        #region Print List
        public void PrintList()
        {
            Node<T> runner = head;
            while (runner != null)
            {
                Console.Write(runner.data.ToString() + " ");
                runner = runner.next;
            }
            Console.Write("\n");
        }
        #endregion

    }
}
