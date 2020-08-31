using CsharpSolution.Linked_Lists;
using System;

namespace CsharpSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------1--------");
            LinkedList list = new LinkedList();
            list.Append(10);
            list.Append(20);
            list.Append(30);
            list.Prepend(50);

            list.PrintList();
        }
    }
}
