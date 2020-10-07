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
            Console.WriteLine($"\t=============================MENUS=============================\n" +
                                             $"\t\t 1.Arrasy And Strings\n" +
                                             $"\t\t 2.Linked List\n" +
                                             $"\t\t 3.Stack\n" +
                                             $"\t\t 4.Queue\n" +
                                             $"\t\t 5.Tree\n" +
                                             $"\t\t 6.Graph\n" +
                                             $"\t\t 7.Advanced Data Structure\n" +
                                             $"\t\t 8.Dynamic Programing\n" +
                              $"\t================================================================");
            Menus m = new Menus();
            try
            {
            Menu:
                
                Console.WriteLine("Press 0 For Exit.");
                Console.WriteLine("Enter Menu No: [1-8]\n");
                int options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    #region Exit
                    case 0:
                        Console.WriteLine("---✔️🍺 Happy Coding 👍😊---\n---Happy Learning See You Latter---");
                        break;
                    #endregion

                    #region Array And String Collection 
                    case 1:
                        Console.WriteLine($"Array And Strings Problems");
                        m.DisplayArrayAndString();
                        goto Menu;
                    #endregion

                    #region Linked list
                    case 2:
                        Console.WriteLine("Linked list Problems");
                        m.DisplayLinkedList();
                        goto Menu;
                    #endregion

                    #region Stack Collection 
                    case 3:
                        Console.WriteLine($"Stack Problems");
                        m.DisplayStack();
                        goto Menu;
                    #endregion

                    #region Queue Collection 
                    case 4:
                        Console.Write($"Queue Problems\t");
                        m.DisplayQueue();
                        goto Menu;
                    #endregion

                    #region Tree  
                    case 5:
                        Console.WriteLine($"Tree Problems");
                        m.DisplayTree();
                        goto Menu;
                    #endregion

                    #region Graph
                    case 6:
                        Console.WriteLine($"Graph Problems");
                        m.DisplayGraph();
                        goto Menu;
                    #endregion

                    #region Advanced Ds
                    case 7:
                        Console.WriteLine("Advanced Ds Problems");
                        m.DisplayAdvancedDs();
                        goto Menu;
                    #endregion

                    #region Dynamic Programing
                    case 8:
                        Console.WriteLine("DP Problems");
                        m.DisplayDynamicProgramming();
                        goto Menu;
                    #endregion
        
                    #region Menu
                    default:
                        Console.Clear();
                        Console.WriteLine("Oops! Invalid Option Typed.");
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
