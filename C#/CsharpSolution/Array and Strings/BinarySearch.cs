using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    class BinarySearch
    {
        //TC:O(logn) if Array is Sorted
        //if not sorted need to sort and apply Binary search then TC:O(nlogn)
        public string BSEarch(int[] arr, int start,int end,int key)
        {
            if(arr.Length==0 || start > end)
            {
                return "Not Found";
            }

            int  mid = 0;
            mid = (start + end)/2;
            if (key == arr[mid])
            {
                return string.Format($"Found {key} at index {mid}");
            }

            if(key> arr[mid])
            {
                return BSEarch(arr, mid + 1, end, key);
            }
            else if (key< arr[mid])
            {
                return BSEarch(arr, start, mid - 1, key);
            }

             return "Not Found";
        }
    }
}
