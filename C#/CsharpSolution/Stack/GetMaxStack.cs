using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CsharpSolution.Stack
{
    class GetMaxStack
    {
        private Stack<int> Sk = new Stack<int>();
        private Stack<int> maxSk = new Stack<int>();

        public void Push(int data)
        {
            Sk.Push(data);
            if (maxSk.Count == 0 || maxSk.Peek() <= data)
            {
                maxSk.Push(data);
            }
        }

        public int Pop()
        {
            
            if (Sk.Count == 0) return 0;
            int v1=Sk.Peek();
            int v2 = maxSk.Peek();
            if (v1 == v2)
            {
                maxSk.Pop();
            }
            return Sk.Pop();
        }

        public int GetMax()
        {
            return maxSk.Peek();
        }

        public int GetTop()
        {
            return Sk.Peek();
        }
    }
}
