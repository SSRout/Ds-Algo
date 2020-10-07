using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution
{
   
    public class Menus
    {    
        public void DisplayMenu(int items)
        {
            MenuItemEnum chocice = (MenuItemEnum)items;
            switch (chocice)
            {
                case MenuItemEnum.ArrasyAndStrings:
                    DisplayArrayAndString();
                    break;
                case MenuItemEnum.LinkedList:
                    DisplayLinkedList();
                    break;
                case MenuItemEnum.Stack:
                    DisplayStack();
                    break;
                case MenuItemEnum.Queue:
                    DisplayQueue();
                    break;
                case MenuItemEnum.Tree:
                    Console.WriteLine("tree");
                    break;
                case MenuItemEnum.Graph:
                    Console.WriteLine("grapg");
                    break;
                case MenuItemEnum.AdvanceDs:
                    Console.WriteLine("advance ds");
                    break;
                case MenuItemEnum.DynamicPrograming:
                    Console.WriteLine("dp");
                    break;
                default:
                    Console.WriteLine("Oops! Invalid Choice.");
                    break;

            }
        }

        public void DisplayArrayAndString()
        {

            Console.WriteLine("Enter Chocice");
            
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("to do");
        }

        public void DisplayLinkedList()
        {

            Console.WriteLine("Enter Chocice");

            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("to do");
        }

        public void DisplayStack()
        {

            Console.WriteLine("Enter Chocice");

            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("to do");
        }

        public void DisplayQueue()
        {

            Console.WriteLine("Enter Chocice");

            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("to do");
        }
    }
}
