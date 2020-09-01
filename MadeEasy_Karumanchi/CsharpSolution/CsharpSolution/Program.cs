using CsharpSolution.Linked_Lists;
using System;

namespace CsharpSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------1.Single Linked List--------");
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
                list.Prepend(i);
            list.InsertAfter(6, 5);
            list.InsertBefore(7, 3);
            list.PrintList();
            Console.WriteLine($"\nLength of List before delete {list.NodeCount()}");
            list.DelteNode(6);
            list.PrintList();
            Console.WriteLine($"\nLength of List after delete {list.NodeCount()}");

            LinkedList<string> list1 = new LinkedList<string>();
            string []str= {"A","B","C","D","E"};
            foreach (var v in str)
                list1.Append(v);
            list1.PrintList();
            list1.SearchNode("D");

        }
    }
}
