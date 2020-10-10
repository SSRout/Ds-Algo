using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    class StringPalindrome
    {
        //Time Complexity: O(n). Space Complexity: O(1).
        public bool CheckPalindrome(string str)
        {
            int i = 0;
            int j = str.Length-1;
            while(i<j && str[i] == str[j])
            {
                i++;
                j--;
            }
            if (i < j)
            {
                return false;
            }
            return true;
        }
    }
}
