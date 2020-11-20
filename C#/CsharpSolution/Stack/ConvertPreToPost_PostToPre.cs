using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class ConvertPreToPost_PostToPre
    {
        public bool IsOperand(char ch)
        {
            return ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
        }
       
        public string ConvertExpression(string exp)
        {
            string result=string.Empty;
            Stack<string> s = new Stack<string>();
            if (IsOperand(exp[0]))//post fix to prefix
            {
                for(int i = 0; i < exp.Length; i++)
                {
                    if (IsOperand(exp[i])){
                        s.Push(exp[i].ToString());
                    }
                    else
                    {
                        string op2 = s.Pop();
                        string op1 = s.Pop();
                        string res = string.Format($"{exp[i]}{op1}{op2}");
                        s.Push(res);
                    }
                }
                result =string.Format($"Postfix to Prefix is {s.Pop()}");
            }
            else//prefix to postfix
            {
                for(int i = exp.Length - 1; i >= 0; i--)
                {
                    if (IsOperand(exp[i]))
                    {
                        s.Push(exp[i].ToString());
                    }
                    else
                    {
                        string op1 = s.Pop();
                        string op2 = s.Pop();
                        string res = string.Format($"{op1}{op2}{exp[i]}");
                        s.Push(res);
                    }
                }
                result = string.Format($"Prefix To Postfix is {s.Pop()}");
            }
            return result;
        }
    }
}
