using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace CsharpSolution.Stack
{
    class StackUsingArray
    {
        protected int capacity;
        protected int[] arrStack;
        protected int top=-1;
        public StackUsingArray(int cap)
        {
            this.capacity = cap;
            arrStack = new int[this.capacity];
        }
        //TC:O(1)
        public int Size()
        {
            return (top + 1);
        }
        //TC:O(1)
        public bool isEmpty()
        {
            return (top < 0);
        }
        //TC:O(1)
        public void Push(int data)
        {
            if (Size() == capacity)
                throw new Exception("Stack is Full");
            arrStack[++top] = data;
        }
        //TC:O(1)
        public int Top()
        {
            if (isEmpty())
                throw new Exception("Stack is Empty");
            return arrStack[top];
        }

        //TC:O(1)
        public int Pop()
        {
            if (isEmpty())
                throw new Exception("Stack is Empty");
            int data = Top();
            arrStack[top--]= -1;
            return data;
        }

        //TC:O(n)
        public void Print()
        {
            if (Size() > 0)
            {
                for(int i = 0; i < Size(); i++)
                {
                    Console.Write($"[{ arrStack[i]}]\n");
                }
            }
            Console.WriteLine();
        }

    }
}
