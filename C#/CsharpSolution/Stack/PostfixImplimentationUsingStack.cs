using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class PostfixImplimentationUsingStack
    {
        public int EvaluatePostfixExpression(string exp)
        {
            Stack<int> s = new Stack<int>();
            for(int i=0;i<exp.Length;i++)
            {
                if (exp[i].Equals('+'))
                {
                    int op2 = s.Pop();
                    int op1 =s.Pop();
                    int res = op1 + op2;
                    s.Push(res);
                }
                else if (exp[i].Equals('-'))
                {
                    int op2 = s.Pop();
                    int op1 = s.Pop();
                    int res = op1 -op2;
                    s.Push(res);
                }
                else if (exp[i].Equals('*'))
                {
                    int op2 = s.Pop();
                    int op1 = s.Pop();
                    int res = op1 * op2;
                    s.Push(res);
                }
                else if (exp[i].Equals('/'))
                {
                    int op2 = s.Pop();
                    int op1 = s.Pop();
                    int res = op1 / op2;
                    s.Push(res);
                }
                else
                {
                    s.Push(Convert.ToInt32(exp[i].ToString()));
                }
            }
            return s.Pop();
        }
    }
}
