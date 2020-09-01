﻿using CsharpSolution.Linked_Lists;
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
                    case 0:
                        Console.WriteLine("---Happy Learning See You Latter---");
                        break;
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


                    case 2:
                        Console.WriteLine("--------2.Doubly Linked List--------");
                        DoublyLinkedList<int> dlist = new DoublyLinkedList<int>();
                        dlist.Append(30);
                        dlist.Append(40);
                        dlist.Prepend(20);
                        dlist.Prepend(10);
                        dlist.PrintList();
                        goto Menu;


                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Option Typed");
                        goto Menu;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something Went Wrong\nCause: {ex.Message}");
            }
        }
    }
}
