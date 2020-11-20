using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace CsharpSolution.Stack
{
    class BalancingSymbolPattern
    {
        /*
         * It Is wildley used in compiler to mentain balance in expressions like {[( 
         * TC:O(n)
         * For this i am using C# Stack collection and Stack ADT with normal exp 
         */
        public bool CheckPattern(string exp,string Type)
        {
            bool res = false;
            if (exp.Length == 0 && exp.Contains(""))
                throw new Exception("Empty Expression");
            int length = exp.Length;
            if (Type.Contains("StackADT"))
            {
                StackUsingLinkedList<string> skAdt = new StackUsingLinkedList<string>();
                for(int i = 0; i < length; i++)
                {
                    if (exp[i] == ')')
                    {
                        if (skAdt.GetSize() > 0 && skAdt.Peek() == "(")
                        {
                            skAdt.Pop();
                        }
                        else
                            return false;
                    }
                    else if(exp[i] == ']')
                    {
                        if (skAdt.GetSize() > 0 && skAdt.Peek() == "[")
                        {
                            skAdt.Pop();
                        }
                        else
                            return false;
                    }
                    else if(exp[i] == '}')
                    {
                        if (skAdt.GetSize() > 0 && skAdt.Peek() == "{")
                        {
                            skAdt.Pop();
                        }
                        else
                            return false;
                    }
                    else
                    {
                        skAdt.Push(exp[i].ToString());
                    }
                    
                }
                if (skAdt.GetSize() == 0)
                    res = true;
                else
                    res = false;
            }
            else
            {
                Stack<string> sk = new Stack<string>();
                for (int i = 0; i < length; i++)
                {
                    if (exp[i] == ')')
                    {
                        if (sk.Count > 0 && sk.Peek() == "(")
                        {
                            sk.Pop();
                        }
                        else
                            return false;
                    }
                    else if (exp[i] == ']')
                    {
                        if (sk.Count > 0 && sk.Peek() == "[")
                        {
                            sk.Pop();
                        }
                        else
                            return false;
                    }
                    else if (exp[i] == '}')
                    {
                        if (sk.Count > 0 && sk.Peek() == "{")
                        {
                            sk.Pop();
                        }
                        else
                            return false;
                    }
                    else
                    {
                        sk.Push(exp[i].ToString());
                    }
                }
                if (sk.Count == 0)
                    res = true;
                else
                    res = false;
            }

            return res;
        }
    }
}
