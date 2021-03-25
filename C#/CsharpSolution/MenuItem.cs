using System;
using CsharpSolution.Array_and_Strings;
using CsharpSolution.Linked_Lists;
using CsharpSolution.Stack;
using CsharpSolution.Tree;

namespace CsharpSolution
{

    public class Menus
    {
        public void DisplayProgramsTopicWise(int items)
        {
            MenuItemEnum chocice = (MenuItemEnum)items;
            switch (chocice)
            {
                case MenuItemEnum.ArrasyAndStrings:
                    Console.WriteLine("Arrasy And Strings");
                    break;
                case MenuItemEnum.LinkedList:
                    Console.WriteLine("Linked List");
                    break;
                case MenuItemEnum.Stack:
                    Console.WriteLine("Stack");
                    break;
                case MenuItemEnum.Queue:
                    Console.WriteLine("Queue");
                    break;
                case MenuItemEnum.Tree:
                    Console.WriteLine("Tree");
                    break;
                case MenuItemEnum.Graph:
                    Console.WriteLine("Graph");
                    break;
                case MenuItemEnum.AdvanceDs:
                    Console.WriteLine("Advance ds");
                    break;
                case MenuItemEnum.DynamicPrograming:
                    Console.WriteLine("Dp");
                    break;
                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;

            }
        }

        public void DisplayArrayAndString()
        {

            Console.WriteLine("Select Question[1-10]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                #region Max Sub Array Sum Using Kadens Algo
                case 1:
                    Console.WriteLine("--------" + choice + ".Max Sub Array Sum Using Kadens Algo--------");
                    FindMaxSubArraySumUsingKadensAlgo o1 = new FindMaxSubArraySumUsingKadensAlgo();
                    int[] arr1 = { 2, -1, -3, 4, -1, 7, -2 };
                    Console.WriteLine(o1.MaxSub(arr1));
                    break;
                #endregion

                #region Binary Search
                case 2:
                    Console.WriteLine("--------" + choice + ".Binary Search--------");
                    BinarySearch o2 = new BinarySearch();
                    int[] arr2 = { 5, 10, 20, 30, 40 };
                    Console.WriteLine(o2.BSEarch(arr2, 0, arr2.Length - 1, 40));
                    break;
                #endregion

                #region Check Palindrome
                case 3:
                    Console.WriteLine("--------" + choice + ".Check Palindrome--------");
                    StringPalindrome o3 = new StringPalindrome();
                    Console.WriteLine("Enter a String to check Palindrome or not");
                    string str3 = Console.ReadLine();
                    Console.WriteLine($"{str3} is palindrome {o3.CheckPalindrome(str3)}");
                    break;
                #endregion

                #region Bubble Sort
                case 4:
                    Console.WriteLine("--------" + choice + ".Bubble Sort--------");
                    int[] arr = { 1,2,3,4 };
                    BubbleSort o4 = new BubbleSort(arr, arr.Length);
                    break;
                #endregion

                #region Insertion Sort
                case 5:
                    Console.WriteLine("--------" + choice + ".Insertion Sort--------");
                    var o5 = new InsertionSort(new int[] { 8, 4, 1, 5 });
                    break;
                #endregion

                #region
                case 6:
                    Console.WriteLine("--------" + choice + ".Selection sort--------");
                    var o6 = new SelectionSort(new int[] {4,6,9,2,3,1});
                    break;
                #endregion

                #region
                case 7:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 8:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 9:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 10:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Inavalid Choice.");
                    break;
            }
        }

        public void DisplayLinkedList()
        {

            Console.WriteLine("Select Question[1-18]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
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
                    break;
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
                    break;

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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
                #endregion

                #region Print LinkedList From End
                case 12:
                    Console.WriteLine("--------12.Print LinkedList From End--------");
                    PrintLinkedListFromEnd p = new PrintLinkedListFromEnd();
                    p.Print();
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
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
                    break;
                #endregion

                #region Plindrome check using Single linked list
                case 18:
                    Console.WriteLine("--------"+choice+".Merge two Sorted Linked list--------");
                    CheckLinkedLisPalindromeUsingSingleLinkedList<int> l18 = new CheckLinkedLisPalindromeUsingSingleLinkedList<int>();
                    l18.InsertFirst(1);
                    l18.InsertFirst(2);
                    l18.InsertFirst(2);
                    l18.InsertFirst(1);
                    l18.Print();
                     l18.CheckPalindrome();
                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;

            }
        }

        public void DisplayStack()
        {
            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                #region CSharp Stack Collection 
                case 1:
                    Console.WriteLine("--------" + choice + ".CSharp Stack Collection --------");
                    StackCollectioninCsharp<int> sk1 = new StackCollectioninCsharp<int>();
                    int[] arr1 = { 10, 78, 34, 65 };
                    foreach (var v in arr1)
                        sk1.Push(v);
                    sk1.Print();
                    Console.WriteLine($"Count is :{sk1.myStack.Count}");
                    Console.WriteLine($"78 Is Present :{sk1.myStack.Contains(78)}");
                    sk1.myStack.Pop();
                    sk1.Print();
                    break;
                #endregion

                #region Stack using Array
                case 2:
                    Console.WriteLine("--------" + choice + ".Stack using Array--------");
                    StackUsingArray sk2 = new StackUsingArray(10);
                    sk2.Push(10);
                    sk2.Push(20);
                    sk2.Push(30);
                    sk2.Push(40);
                    sk2.Print();
                    sk2.Pop();
                    sk2.Print();
                    break;
                #endregion

                #region Stack Using Linked List
                case 3:
                    Console.WriteLine("--------" + choice + ".Stack Using Linked List--------");
                    StackUsingLinkedList<int> sk3 = new StackUsingLinkedList<int>();
                    int[] arr3 = { 10, 20, 30, 40 };
                    foreach (var v in arr3)
                        sk3.Push(v);
                    sk3.Print();
                    sk3.Peek();
                    sk3.Print();
                    sk3.Pop();
                    sk3.Print();
                    Console.WriteLine($"Size Of Stack: {sk3.GetSize()}");
                    break;
                #endregion

                #region Balanced Expression
                case 4:
                    Console.WriteLine("--------" + choice + ".Balanced Expression--------");
                    BalancingSymbolPattern sk4 = new BalancingSymbolPattern();
                    Console.WriteLine($"Expression is Balanced using Stack: {sk4.CheckPattern("[{(}]", "Stack")}");
                    Console.WriteLine($"Expression is Balanced  using Stack Adt: {sk4.CheckPattern("[{)}]", "StackADT")}");
                    Console.WriteLine($"Expression is Balanced using Stack: {sk4.CheckPattern("[{()}]", "Stack")}");
                    Console.WriteLine($"Expression is Balanced  using Stack Adt: {sk4.CheckPattern("[{()}]", "StackADT")}");
                    break;
                #endregion

                #region Postfix Expression Evaluation Using Stack
                case 5:
                    Console.WriteLine("--------" + choice + ".Postfix Expression Evaluation  Using Stack--------");
                    PostfixImplimentationUsingStack sk5 = new PostfixImplimentationUsingStack();
                    Console.WriteLine($"Postfix Expression result is {sk5.EvaluatePostfixExpression("123*+5-")}");
                    break;
                #endregion

                #region Infix to Postfix
                case 6:
                    Console.WriteLine("--------" + choice + ".Infix to Postfix--------");
                    InfixToPostFix sk6 = new InfixToPostFix();
                    string exp = "a+b*(c^d-e)^(f+g*h)-i";
                    //string exp ="a*b-(c+d)-e";
                    Console.WriteLine($"Infix {exp} of  Postfix is : {sk6.ConvertInfixToPostFix(exp.Replace(" ", string.Empty))}");
                    break;
                #endregion

                #region Infix To Prefix
                case 7:
                    Console.WriteLine("--------" + choice + ".Infix To Prefix--------");
                    InfixToPrefix sk7 = new InfixToPrefix();
                    //string exp7 = "a*b-(c+d)-e";
                    string exp7 = "((a/b)+c)-(d+(e*f))";
                    Console.WriteLine($"Infix {exp7} of Prefix is {sk7.ConvertInfixToPrefix(exp7.Replace(" ", string.Empty))}");
                    break;
                #endregion

                #region Convert Prefix and Postfix to Infix
                case 8:
                    Console.WriteLine("--------" + choice + ".Convert Prefix and Postfix to Infix--------");
                    ConvertToInfix sk8 = new ConvertToInfix();
                    string exppre8 = "*-A/BC-/AKL";
                    Console.WriteLine($"Pefix {exppre8} of Infix is {sk8.ConvertPreToInfix(exppre8.Replace(" ", string.Empty))}");
                    string expost8 = " ab*c+";
                    Console.WriteLine($"Postfix {expost8} of Infix is {sk8.ConvertPostToInfix(expost8.Replace(" ", string.Empty))}");
                    break;
                #endregion

                #region Convert Post to Pre and Viceversa
                case 9:
                    Console.WriteLine("--------" + choice + ".Convert Post to Pre and Viceversa--------");
                    ConvertPreToPost_PostToPre sk9 = new ConvertPreToPost_PostToPre();
                    string exp9 = "*-A/BC-/AKL";
                    Console.WriteLine(sk9.ConvertExpression(exp9.Replace(" ", string.Empty)));
                    break;
                #endregion

                #region Sort Stack using Recursion
                case 10:
                    Console.WriteLine("--------" + choice + ".Sort Stack using Recursion--------");
                    string str10 = "-3 14 18 -5 30";
                    SortStack sk10 = new SortStack(str10);
                    sk10.PrintStack();
                    break;
                #endregion

                #region Get Min From Stack with O(1)
                case 11:
                    Console.WriteLine("--------" + choice + ". Get Min From Stack with O(1)--------");
                    GetMinStack sk11 = new GetMinStack();
                    sk11.Push(2);
                    sk11.Push(4);
                    sk11.Push(6);
                    sk11.Push(1);
                    sk11.Push(5);
                    Console.WriteLine("Stack is 5,1,6,4,2");
                    Console.WriteLine($"min value in stack is {sk11.GetMin()} and top of stack is {sk11.Top()}");
                    sk11.Pop();
                    sk11.Pop();
                    Console.WriteLine("After 2 Pops");
                    Console.WriteLine($"min value in stack is {sk11.GetMin()} and top of stack is {sk11.Top()}");
                    break;
                #endregion

                #region Get MAX From Stack with O(1)
                case 12:
                    Console.WriteLine("--------" + choice + ".Get MAX From Stack with O(1)--------");
                    GetMaxStack sk12 = new GetMaxStack();
                    sk12.Push(2);
                    sk12.Push(7);
                    sk12.Push(6);
                    sk12.Push(8);
                    sk12.Push(5);
                    Console.WriteLine("Stack is 5,8,6,7,2");
                    Console.WriteLine($"Max value in stack is {sk12.GetMax()} and top of stack is {sk12.GetTop()}");
                    sk12.Pop();
                    sk12.Pop();
                    Console.WriteLine("After 2 Pops");
                    Console.WriteLine($"Max value in stack is {sk12.GetMax()} and top of stack is {sk12.GetTop()}");
                    break;
                #endregion

                #region
                case 13:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 14:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 15:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Inavalid Choice.");
                    break;
            }

        }

        public void DisplayQueue()
        {

            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;
            }
        }

        public void DisplayTree()
        {

            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                #region
                case 1:
                    Console.WriteLine("--------" + choice + ".--------");
                    TreeDs t1 = new TreeDs();
                    var node = t1.CreateNode(10);
                    t1.AddToTree(20,node);
                    t1.AddToTree(5, node);
                    t1.AddToTree(7, node);
                    t1.AddToTree(3, node);
                    t1.AddToTree(11, node);
                    t1.AddToTree(12, node);
                    t1.AddToTree(25, node);
                    Console.WriteLine("InOrder Traversal");
                    t1.Travers_Inorder(node);

                    Console.WriteLine("\nPreOrder Traversal");
                    t1.Travers_Preorder(node);

                    Console.WriteLine("\nPostOrder Traversal");
                    t1.Travers_Postorder(node);
                    break;
                #endregion

                #region
                case 2:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 3:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 4:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 5:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 6:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 7:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 8:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 9:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 10:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion
                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;
            }
        }

        public void DisplayGraph()
        {

            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                #region
                case 1:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 2:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 3:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 4:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 5:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 6:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 7:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 8:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 9:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 10:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;
            }
        }

        public void DisplayAdvancedDs()
        {

            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                #region
                case 1:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 2:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 3:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 4:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 5:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 6:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 7:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 8:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 9:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 10:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;
            }
        }

        public void DisplayDynamicProgramming()
        {

            Console.WriteLine("Select Question[1-12]");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                #region
                case 1:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 2:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 3:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 4:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 5:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 6:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 7:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 8:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 9:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                #region
                case 10:
                    Console.WriteLine("--------" + choice + ".--------");

                    break;
                #endregion

                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;
            }
        }

    }
}
