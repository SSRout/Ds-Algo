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
                        Console.WriteLine("---✔️🍺 Happy Coding 👍😊---\n---Happy Learning See You Latter---");
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

                    #region Detect Loop With Brute Force Approach
                    case 5:
                        Console.WriteLine("--------5.Detect loop Using Brute Force Approach--------");
                        DetectLoopInLinkedListUsingBF<string> lop2 = new DetectLoopInLinkedListUsingBF<string>();
                        lop2.Insert("A");
                        lop2.Insert("B");
                        lop2.Insert("C");
                        lop2.Insert("D");
                        lop2.Insert("E");
                        /*Create loop for testing */
                        lop2.head.next.next.next = lop2.head;
                        Console.WriteLine(lop2.DetectLoop());
                        goto Menu;
                    #endregion

                    #region Detect Loop Using  Floyd’s Cycle
                    case 6:
                        Console.WriteLine("--------6.Detect loop Using Floyd’s Cycle--------");
                        DetectLoopInLinkedListUsing_FloydCycle<int> lop3 = new DetectLoopInLinkedListUsing_FloydCycle<int>();
                        lop3.push(40);
                        lop3.push(30);
                        lop3.push(20);
                        lop3.push(10);
                        /*Create loop for testing */
                        lop3.head.next.next.next.next = lop3.head;
                        lop3.DetectLoop();
                        goto Menu;
                    #endregion

                    #region Palindrome Check Of Linked List Using Stack
                    case 7:
                        Console.WriteLine("--------7.Palindrome Check Of Linked List Using Stack--------");
                        CheckLinkedListPalindromeUsingStack<int> pal1 = new CheckLinkedListPalindromeUsingStack<int>();
                        pal1.Push(40);
                        pal1.Push(30);
                        pal1.Push(20);
                        pal1.Push(30);
                        pal1.Push(40);
                        pal1.Print();
                        pal1.CheckPalindrome();
                        goto Menu;
                    #endregion

                    #region Reverse LinkedList
                    case 8:
                        Console.WriteLine("--------8.Reverse LinkedList--------");
                        ReverseLinkedList<char> rev = new ReverseLinkedList<char>();
                        char[] val = { 'a', 'b', 'c' };
                        for (int i = 0; i < val.Length; i++)
                        {
                            rev.Push(val[i]);
                        }
                        rev.PrintList();
                        rev.ReverseList();
                        Console.WriteLine("After Reverse");
                        rev.PrintList();
                        goto Menu;
                    #endregion

                    #region Reverse Linked List Using Recursion
                    case 9:
                        Console.WriteLine("--------9.Reverse Linked List Using Recursion--------");
                        ReverseLinkedListUsingRecursion rev2 = new ReverseLinkedListUsingRecursion();
                        rev2.Append(10);
                        rev2.Append(20);
                        rev2.Append(30);
                        rev2.Print();
                        rev2.Reverse();
                        rev2.Print();
                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 10:
                        Console.WriteLine("--------10.--------");
                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 11:
                        Console.WriteLine("--------11.--------");
                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 12:
                        Console.WriteLine("--------12.--------");
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
