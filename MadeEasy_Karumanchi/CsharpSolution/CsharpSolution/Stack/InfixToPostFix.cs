using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class InfixToPostFix
    {
        //TC:O(n)
        public int getPrecrdence(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }

        public bool IsOperand(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
        }
        public string ConvertInfixToPostFix(string exp)
        {

            StringBuilder sb = new StringBuilder();
            Stack<string> sk = new Stack<string>();
            for(int i = 0; i < exp.Length; i++)
            {
                if (IsOperand(exp[i]))
                {
                    sb.Append(exp[i].ToString());
                }
                else if (exp[i].Equals('('))
                {
                    sk.Push(exp[i].ToString());
                }
                else if (exp[i].Equals(')'))
                {
                    while(sk.Count>0 && sk.Peek() != "("){
                        sb.Append(sk.Pop());
                    }
                    if (sk.Count>0 && sk.Peek() != "(")
                        return null;
                    else
                        sk.Pop();
                }
                else // an operator is encountered
                {
                    while(sk.Count>0 && getPrecrdence(exp[i])<=getPrecrdence(Convert.ToChar(sk.Peek()))){
                        sb.Append(sk.Pop());
                    }
                    sk.Push(exp[i].ToString());
                }
            }
            // pop them all out
            while (sk.Count > 0 )
            {
                sb.Append(sk.Pop());
            }
            return sb.ToString();
        }
    }
}
