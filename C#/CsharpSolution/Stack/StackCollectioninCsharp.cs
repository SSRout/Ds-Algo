using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class StackCollectioninCsharp<T>
    {
        //using c# stack collection class
        public Stack<T> myStack;
        public StackCollectioninCsharp()
        {
            myStack = new Stack<T>();
        }

        public void  Push(T data)
        {
            myStack.Push(data);
        }

        public void Print()
        {
            foreach(var v in myStack)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();
        }
    }
}
