using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    class FindMaxSubArraySumUsingKadensAlgo
    {
        //TC:O(n)
        public string MaxSub(int[] arr)
        {
            int maxSoFar =arr[0], currentMax = arr[0];
            int start = 0, end = 0, search = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                currentMax = currentMax + arr[i];
                if (maxSoFar < currentMax)
                {
                    maxSoFar = currentMax;
                    start = search;
                    end = i;
                }
                if (currentMax < 0)
                {
                    currentMax = 0;
                    search= i+1;
                }
            }
            return string.Format($"Sum Of Max Sub Arry is { maxSoFar} start index {start} end index {end}");
        }
    }
}
