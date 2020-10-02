using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class ConvertToInfix
    {
        public bool IsOperand(char ch)
        {
            return ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
        }
        public string ConvertPreToInfix(string exp)
        {
            Stack<string> s = new Stack<string>();
            for(int i = exp.Length-1; i >= 0; i--)
            {
                if(IsOperand(exp[i]))
                {
                    s.Push(exp[i].ToString());
                }
                else
                {
                    string op1 = s.Pop();
                    string op2 = s.Pop();
                    string res = "(" + op1 + exp[i].ToString() + op2 + ")";
                    s.Push(res);
                }
            }
            return s.Pop();
        }

        public string ConvertPostToInfix(string exp)
        {
            Stack<string> s = new Stack<string>();
            for(int i = 0; i < exp.Length; i++)
            {
                if (IsOperand(exp[i]))
                {
                    s.Push(exp[i].ToString());
                }
                else
                {
                    string op2 = s.Pop();
                    string op1 = s.Pop();
                    string res = string.Format($"({op1}{exp[i]}{op2})");
                    s.Push(res);
                }
            }
            return s.Pop();
        }
    }
}
