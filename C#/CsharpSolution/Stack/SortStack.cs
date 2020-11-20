using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class SortStack
    {
        private Stack<int> sk = new Stack<int>();
        public SortStack(string str)
        {
            InitializeStzck(str);
            StackSort(sk);
        }

        private void InitializeStzck(string str)
        {
            int[] arr = Array.ConvertAll(str.Split(' '), s => int.Parse(s));
            for(int i = 0; i < arr.Length; i++)
            {
                sk.Push(arr[i]);
            }
        }

        private void StackSort(Stack<int> sk)
        {
            if (sk.Count > 0)
            {
                int x = sk.Peek();
                sk.Pop();
                StackSort(sk);
                SortUtil(sk, x);
            }
        }

        private void SortUtil(Stack<int> sk, int x)
        {
            // Base case: Either stack is empty or  newly inserted item is greater than top  
            if (sk.Count == 0 || x > sk.Peek())
            {
                sk.Push(x);
                return;
            }
            int temp = sk.Peek();
            sk.Pop();
            SortUtil(sk, x);
            sk.Push(temp);
        }

        public void PrintStack()
        {
            while (sk.Count > 0)
            {
                Console.WriteLine(sk.Pop());
            }
        }
    }
}
