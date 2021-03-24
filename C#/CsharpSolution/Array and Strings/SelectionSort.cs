using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    //O(n^2)
    public class SelectionSort
    {
        public SelectionSort(int[] arr)
        {
            var res = Sort(arr, arr.Length);
            foreach(var r in res)
            {
                Console.Write($"{r} ");
            }
        }

        private int[] Sort(int[] arr, int n)
        {
            for(int i = 0; i < n - 1;  i++)
            {
                int min = i;
                for(int j = i; j < n-1; j++)
                {
                    if (arr[j+1] < arr[min])
                    {
                        min = j+1 ;
                    }
                }
                if (i != min)
                    Swap(arr, min, i);
            }
            return arr;
        }

        private void Swap(int[] arr, int min, int i)
        {
            var temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
}
