using CsharpSolution.Linked_Lists;
using System;

namespace CsharpSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Menu:
                Console.WriteLine("Press 0 For Exit.");
                Console.WriteLine("Enter Question No: [1-100]\n");
                int options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    #region Exit
                    case 0:
                        Console.WriteLine("---Happy Learning See You Latter---");
                        break;
                    #endregion

                    #region Single Linked List
                    case 1:

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
                        string[] str = { "A", "B", "C", "D", "E" };
                        foreach (var v in str)
                            list1.Append(v);
                        list1.PrintList();
                        list1.SearchNode("D");
                        goto Menu;
                    #endregion

                    #region Double Linked List
                    case 2:
                        Console.WriteLine("--------2.Doubly Linked List--------");
                        DoublyLinkedList<int> dlist = new DoublyLinkedList<int>();
                        dlist.Append(40);
                        dlist.Prepend(10);
                        dlist.InsertAtMiddle(60, 1);
                        dlist.InsertAtMiddle(70, 3);
                        dlist.PrintList();
                        dlist.Delete(3);
                        dlist.NodeSearch(40);
                        dlist.NodeCount();
                        dlist.PrintList();
                        goto Menu;

                    #endregion

                    #region Circular Linked List
                    case 3:
                        Console.WriteLine("--------3.Circular Linked List--------");
                        CircularLinkedList<string> clist = new CircularLinkedList<string>();
                        clist.Prepend("A");
                        clist.Append("B");
                        clist.Prepend("C");
                        clist.Append("D");
                        clist.InsertAt("E", 4);
                        clist.NodeSearch("A");
                        clist.PrintList();
                        clist.NodeCount();
                        clist.Delete("E");
                        clist.PrintList();
                        goto Menu;
                    #endregion

                    #region Detect loop Using HasSet
                    case 4:
                        Console.WriteLine("--------4.Detect loop Using HasSet--------");
                        DetectLoopInLinkedListUsingHasSet<int> lop1 = new DetectLoopInLinkedListUsingHasSet<int>();
                        lop1.Push(10);
                        lop1.Push(20);
                        lop1.Push(30);
                        lop1.Push(40);
                        lop1.Push(50);
                        /*Create loop for testing */
                        lop1.head.next.next.next.next = lop1.head;
                        lop1.DetectLoop();
                        goto Menu;
                    #endregion

                    #region Menu
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Option Typed");
                        goto Menu;
                        #endregion
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something Went Wrong\nCause: {ex.Message}");
            }
        }
    }
}
