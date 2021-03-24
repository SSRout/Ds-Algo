using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    public class InsertionSort
    {
        public InsertionSort(int[] arr)
        {
            var  res=Sort(arr,arr.Length);
            foreach(var r in res)
            {
                Console.Write($"{r} ");
            }
        }

        private int[] Sort(int[] arr,int n)
        {
            for(int i = 1; i < n; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j>=0 && arr[j]>temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = temp;
            }
            return arr;
        }
    }
}
