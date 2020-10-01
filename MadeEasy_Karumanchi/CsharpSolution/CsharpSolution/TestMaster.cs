using CsharpSolution.Array_and_Strings;
using CsharpSolution.Linked_Lists;
using CsharpSolution.Stack;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net.Http.Headers;

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

                    #region Remove Duplicate From Sorted LinkedList
                    case 10:
                        Console.WriteLine("--------10.Remove Duplicate From Sorted LinkedList--------");
                        RemoveDuplicateFromSortedLinkedList dct = new RemoveDuplicateFromSortedLinkedList();
                        int[] arr = { 10, 10, 20, 30, 30, 40 };
                        foreach (var i in arr)
                            dct.Insert(i);
                        dct.Print();
                        dct.RemoveDuplicate();
                        dct.Print();
                        goto Menu;
                    #endregion

                    #region Removing Duplicate From Unsorted LinkedList using Hashing
                    case 11:
                        Console.WriteLine("--------11.Removing Duplicate From Unsorted LinkedList using Hashing--------");
                        RemovingDuplicateFromUnsortedLinkedList dct1 = new RemovingDuplicateFromUnsortedLinkedList();
                        int[] lst = { 10, 30, 20, 30, 50, 10 };
                        foreach (var i in lst)
                            dct1.Push(i);
                        dct1.Print();
                        dct1.RemoveDuplicate();
                        dct1.Print();
                        goto Menu;
                    #endregion

                    #region Print LinkedList From End
                    case 12:
                        Console.WriteLine("--------12.Print LinkedList From End--------");
                        PrintLinkedListFromEnd p = new PrintLinkedListFromEnd();
                        p.Print();
                        goto Menu;
                    #endregion

                    #region Swap nodes in a linked list
                    case 13:
                        Console.WriteLine("--------13.Swap nodes in a linked list--------");
                        SwapNodesInLinkedlist swa = new SwapNodesInLinkedlist();
                        int[] ar13 = { 10, 12, 15, 16, 18, 20 };
                        foreach (var v in ar13)
                            swa.Push(v);
                        swa.PrintUsingRecursion(swa.head);
                        Console.WriteLine();
                        swa.Swap(12, 18);
                        swa.Print();
                        goto Menu;
                    #endregion

                    #region Reverse Double Linked List
                    case 14:
                        Console.WriteLine("--------14.Reverse Double Linked List--------");
                        ReverseDoubleLinkedList rd = new ReverseDoubleLinkedList();
                        int[] ar14 = { 10, 20, 30, 40 };
                        foreach (var v in ar14)
                            rd.Insert(v);
                        rd.Print();
                        rd.Reverse();
                        goto Menu;
                    #endregion

                    #region Reverse Pair Wise
                    case 15:
                        Console.WriteLine("--------15.Reverse Pair Wise--------");
                        ReverseLinkedListPairWise l15 = new ReverseLinkedListPairWise();
                        int[] ar15 = { 10, 20, 30, 40, 50 };
                        foreach (var v in ar15)
                            l15.Push(v);
                        l15.Print();
                        l15.Reverse();
                        l15.Print();
                        goto Menu;
                    #endregion

                    #region Split circular linked List in 2 halfs
                    case 16:
                        Console.WriteLine("--------16.Split circular linked List in 2 halfs--------");
                        SplitCircularLinkedList_inTwoParts o16 = new SplitCircularLinkedList_inTwoParts();
                        int[] ar16 = { 50, 60, 20, 30, 13, 40, 56, 73, 10 };
                        foreach (var v in ar16)
                            o16.push(v);
                        o16.head.next.next.next.next.next.next.next.next.next = o16.head;
                        o16.Print(o16.head);
                        o16.SplitList(o16.head);
                        o16.Print(o16.head1);
                        o16.Print(o16.head2);
                        goto Menu;
                    #endregion

                    #region Merge two Sorted Linked list
                    case 17:
                        Console.WriteLine("--------17.Merge two Sorted Linked list--------");
                        Merge2SortedLinkedList l17 = new Merge2SortedLinkedList();
                        l17.CreateList1();
                        l17.CreateList2();
                        l17.Print(l17.h1);
                        l17.Print(l17.h2);
                        l17.MegeList(l17.h1, l17.h2);
                        l17.Print(l17.head);
                        goto Menu;
                    #endregion

                    #region CSharp Stack Collection 
                    case 18:
                        Console.WriteLine("--------18.CSharp Stack Collection --------");
                        StackCollectioninCsharp<int> o18 = new StackCollectioninCsharp<int>();
                        int[] ar18 = { 10, 78, 34, 65 };
                        foreach (var v in ar18)
                            o18.Push(v);
                        o18.Print();
                        Console.WriteLine($"Count is :{o18.myStack.Count}");
                        Console.WriteLine($"78 Is Present :{o18.myStack.Contains(78)}");
                        o18.myStack.Pop();
                        o18.Print();
                        goto Menu;
                    #endregion

                    #region Stack using Array
                    case 19:
                        Console.WriteLine("--------19.Stack using Array--------");
                        StackUsingArray sc19 = new StackUsingArray(10);
                        sc19.Push(10);
                        sc19.Push(20);
                        sc19.Push(30);
                        sc19.Push(40);
                        sc19.Print();
                        sc19.Pop();
                        sc19.Print();
                        goto Menu;
                    #endregion

                    #region Stack Using Linked List
                    case 20:
                        Console.WriteLine("--------20.Stack Using Linked List--------");
                        StackUsingLinkedList<int> sc20 = new StackUsingLinkedList<int>();
                        int[] ar20 = { 10, 20, 30, 40 };
                        foreach (var v in ar20)
                            sc20.Push(v);
                        sc20.Print();
                        sc20.Peek();
                        sc20.Print();
                        sc20.Pop();
                        sc20.Print();
                        Console.WriteLine($"Size Of Stack: {sc20.GetSize()}");
                        goto Menu;
                    #endregion

                    #region Balanced Expression
                    case 21:
                        Console.WriteLine("--------21.Balanced Expression--------");
                        BalancingSymbolPattern sc21 = new BalancingSymbolPattern();
                        Console.WriteLine($"Expression is Balanced using Stack: {sc21.CheckPattern("[{(}]", "Stack")}");
                        Console.WriteLine($"Expression is Balanced  using Stack Adt: {sc21.CheckPattern("[{)}]", "StackADT")}");
                        Console.WriteLine($"Expression is Balanced using Stack: {sc21.CheckPattern("[{()}]", "Stack")}");
                        Console.WriteLine($"Expression is Balanced  using Stack Adt: {sc21.CheckPattern("[{()}]", "StackADT")}");
                        goto Menu;
                    #endregion

                    #region Postfix Expression Evaluation Using Stack
                    case 22:
                        Console.WriteLine("--------22.Postfix Expression Evaluation  Using Stack--------");
                        PostfixImplimentationUsingStack sk22 = new PostfixImplimentationUsingStack();
                        Console.WriteLine($"Postfix Expression result is {sk22.EvaluatePostfixExpression("123*+5-")}");
                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 23:
                        Console.WriteLine("--------23.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 24:
                        Console.WriteLine("--------24.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 25:
                        Console.WriteLine("--------25.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 26:
                        Console.WriteLine("--------26.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 27:
                        Console.WriteLine("--------27.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 28:
                        Console.WriteLine("--------28.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 29:
                        Console.WriteLine("--------29.--------");

                        goto Menu;
                    #endregion

                    #region MyRegion
                    case 30:
                        Console.WriteLine("--------30.--------");

                        goto Menu;
                    #endregion

                    //#region Max Sub Array Sum Using Kadens Algo
                    //case 23:
                    //    Console.WriteLine("--------23.Max Sub Array Sum Using Kadens Algo--------");
                    //    FindMaxSubArraySumUsingKadensAlgo o23 = new FindMaxSubArraySumUsingKadensAlgo();
                    //    int[] arr23 = { 2, -1, -3, 4, -1, 7, -2 };
                    //    Console.WriteLine(o23.MaxSub(arr23));
                    //    goto Menu;
                    //#endregion

                    //#region Binary Search
                    //case 24:
                    //    Console.WriteLine("--------24.Binary Search--------");
                    //    BinarySearch o24 = new BinarySearch();
                    //    int[] arr24 = { 5, 10, 20, 30, 40 };
                    //    Console.WriteLine(o24.BSEarch(arr24, 0, arr24.Length - 1, 40));
                    //    goto Menu;
                    //#endregion

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
