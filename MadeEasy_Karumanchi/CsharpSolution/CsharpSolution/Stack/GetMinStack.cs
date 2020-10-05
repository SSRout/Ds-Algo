using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class GetMinStack
    {
        private Stack<int> sk = new Stack<int>();
        private Stack<int> minSk = new Stack<int>();
        public void Push(int data)
        {
            sk.Push(data);
            if (minSk.Count==0 || minSk.Peek() >= data)
            {
                minSk.Push(data);
            }
        }

        public int Pop()
        {
            if (sk.Count == 0)
            {
                return 0;
            }
            int v1 = sk.Peek();
            int v2 = minSk.Peek();
            if (v1 == v2)
            {
                minSk.Pop();
            }
            return sk.Pop();
        }

        public int GetMin()
        {
            return minSk.Peek();
        }

        public int Top()
        {
            return sk.Peek();
        }

    }
}
