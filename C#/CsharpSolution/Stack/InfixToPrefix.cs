using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Stack
{
    class InfixToPrefix
    {
        //TC:O(n)
        public string getReverse(string exp)
        {
            //swap both "(" with ")"
            char[] str = exp.ToCharArray();
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                if (exp[length - 1 - i].ToString() == "(")
                {
                    str[i] = ')';
                }
                else if (exp[length - 1 - i].ToString() == ")")
                {
                    str[i] = '(';
                }
                else
                {
                    str[i] = exp[length - 1 - i];
                }
            }
            return new string(str);
        }

        public int GetPrecedence(char c)
        {
            if(c=='+'|| c == '-')
            {
                return 1;
            }
            else if (c == '*' || c == '/')
            {
                return 2;
            }
            else if (c == '^')
            {
                return 3;
            }
            else
            {
                return -1;
            }
        }

        public bool IsDigit(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
        }
        public string ConvertInfixToPrefix(string exp)
        {
            Stack<string> skPrefix = new Stack<string>();
            StringBuilder prefix = new StringBuilder();
            string str = getReverse(exp);
            for(int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                {
                    prefix.Append(str[i]);
                }
                else if (str[i].Equals('('))
                {
                    skPrefix.Push(str[i].ToString());
                }
                else if (str[i].ToString()==")")
                {
                    while(skPrefix.Count>0 && skPrefix.Peek() != "(")
                    {
                        prefix.Append(skPrefix.Pop());
                    }
                    if (skPrefix.Count > 0 && skPrefix.Peek() != "(")
                        return null;
                    else
                        skPrefix.Pop();
                }
                else// an operator is encountered
                {
                    while(skPrefix.Count>0 && GetPrecedence(str[i]) <= GetPrecedence(Convert.ToChar(skPrefix.Peek())))
                    {
                        prefix.Append(skPrefix.Pop());
                    }
                    skPrefix.Push(str[i].ToString());
                }
            }
            // pop them all out
            while (skPrefix.Count > 0)
            {
                prefix.Append(skPrefix.Pop());
            }
            return getReverse(prefix.ToString());
        }
    }
}
